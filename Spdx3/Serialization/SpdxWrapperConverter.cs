using System.Collections;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Spdx3.Exceptions;
using Spdx3.Model;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Serialization;

internal class SpdxWrapperConverter<T> : JsonConverter<T>
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeof(T) != typeof(PhysicalSerialization))
        {
            throw new Spdx3SerializationException($"Can only read classes of type {typeof(PhysicalSerialization)} ");
        }

        var result = (T?)Activator.CreateInstance(typeToConvert, true);
        if (result == null)
        {
            throw new Spdx3SerializationException($"Could not create instance of type {typeof(T)}");
        }

        // We keep a hashtable of values of objects in the @graph array as we read them, and then turn each 
        // hashtable into an SpdxBaseClass object from the model
        Dictionary<string, object>? hashTable = null;
        
        // As we read the object properties, first we read the name, then we read the value.  This is the name and
        // the key into the hashtable that we're about to set.
        var hashTableKey = String.Empty;
        
        // This is whatever array we happen to be in the middle of populating
        List<object>? currentArray = null;
        
        while (reader.Read())
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.PropertyName:
                    var propertyName = reader.GetString();
                    Console.WriteLine($"Property name: '{propertyName}'");
                    
                    if (reader.CurrentDepth < 2)
                    {
                        // Nothing to do at the first level
                        break;
                    }

                    hashTableKey = propertyName;
                    if (hashTableKey == null)
                    {
                        throw new Spdx3Exception("Expected a property name but got null value");
                    }

                    break;

                case JsonTokenType.String:
                    var strVal = reader.GetString();
                    Console.WriteLine($"String value: '{strVal}'");

                    if (reader.CurrentDepth < 2)
                    {
                        // This must be the @context or the @graph, in which case there's nothing to do
                        continue;
                    }

                    if (strVal == null)
                    {
                        throw new Spdx3SerializationException($"Null value encountered for string value for {hashTableKey}");
                    }

                    if (currentArray == null) {
                        if (hashTableKey == null)
                        {
                            throw new Spdx3SerializationException(
                                $"No hashtable key for value {strVal}");
                        }

                        hashTable[hashTableKey] = strVal;
                    }
                    else
                    {
                        currentArray.Add(strVal);
                    }

                    break;

                case JsonTokenType.Number:
                    var intVal = reader.GetInt32();
                    Console.WriteLine($"Integer value: '{intVal}'");

                    if (reader.CurrentDepth < 2)
                    {
                        // This must be the @context or the @graph, in which case there's nothing to do
                        continue;
                    }

                    if (currentArray == null)
                    {
                        if (hashTableKey == null)
                        {
                            throw new Spdx3SerializationException(
                                $"No hashtable key for value {intVal}");
                        }

                        hashTable[hashTableKey] = intVal;
                    }
                    else
                    {
                        currentArray.Add(intVal);
                    }

                    break;


                case JsonTokenType.StartArray:
                    Console.WriteLine("Starting array");
                    
                    if (reader.CurrentDepth < 2)
                    {
                        // We're just starting the @graph array, nothing more to do here
                        continue;
                    }

                    if (currentArray != null)
                    {
                        throw new Spdx3SerializationException("Can't process nested array values");
                    }
                    currentArray = [];
                    break;

                case JsonTokenType.EndArray:
                    Console.WriteLine("Ending array");

                    if (reader.CurrentDepth < 2)
                    {
                        break;
                    }

                    if (currentArray == null)
                    {
                        throw new Spdx3SerializationException("End of array but no array value available");
                    }

                    if (hashTable == null)
                    {
                        throw new Spdx3SerializationException("End of array but not in a property value");
                    }

                    hashTable[hashTableKey] = currentArray;
                    currentArray = null;
                    break;

                case JsonTokenType.StartObject:
                    Console.WriteLine("Starting object");

                    // Start a new hashtable to collect values in for this object
                    if (reader.CurrentDepth > 0)
                    {
                        if (hashTable != null)
                        {
                            throw new Spdx3SerializationException("Can't process nested object values");
                        }
                        hashTable = new Dictionary<string, object>();
                    }
                    
                    break;

                case JsonTokenType.EndObject:
                    Console.WriteLine("Ending object");

                    if (reader.CurrentDepth < 2)
                    {
                        break;
                    }
                    // Turn the hashtable into an Spdx class
                    if (hashTable == null)
                    {
                        throw new Spdx3SerializationException("End of object but no hashtable of values available");
                    }
                    var cls = GetObjectFromHashTable(hashTable);
                    if (cls == null)
                    {
                        throw new Spdx3SerializationException("Unable to get an Spdx class from properties of object");
                    }
                    (result as PhysicalSerialization).Graph.Add(cls);
                    hashTable = null;
                    break;

                default:
                    throw new Spdx3SerializationException($"Unexpected token type {reader.TokenType}");
            }
        }

        return result;
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            throw new Spdx3SerializationException("Value cannot be null.");
        }

        var props = value.GetType().GetProperties();

        writer.WriteStartObject();

        foreach (var prop in props.Where(prop => prop.GetValue(value) != null))
        {
            var jsonElementName = GetJsonElementNameFromPropertyAttribute(prop);

            var propType = prop.PropertyType;
            var propVal = prop.GetValue(value);

            switch (propVal)
            {
                // If it's a list of OTHER SpdxClasses, don't serialize the objects, just serialize an array of references
                case IList spdxClasses:
                {
                    writer.WritePropertyName(jsonElementName);
                    writer.WriteStartArray();
                    foreach (var spdxClass in spdxClasses)
                    {
                        if (spdxClass != null)
                        {
                            JsonSerializer.Serialize(writer, spdxClass, options);
                        }
                    }

                    writer.WriteEndArray();

                    continue;
                }
                case string:
                    writer.WriteString(jsonElementName, propVal.ToString());
                    break;
            }
        }

        writer.WriteEndObject();
    }

    private static string GetJsonElementNameFromPropertyAttribute(PropertyInfo prop)
    {
        var jsonElementName = "";
        foreach (var propAttr in prop.GetCustomAttributes())
        {
            if (propAttr is JsonPropertyNameAttribute)
            {
                jsonElementName = (propAttr as dynamic).Name;
            }
        }

        return jsonElementName;
    }

    private static PropertyInfo? GetPropertyFromJsonElementName(Type typeToConvert, string elementName)
    {
        var eName = Regex.Replace(elementName, @"^spdx:.*/", "");
        foreach (var prop in typeToConvert.GetProperties())
        {
            foreach (var propAttr in prop.GetCustomAttributes())
            {
                if (propAttr is JsonPropertyNameAttribute && eName == (propAttr as dynamic).Name)
                {
                    return prop;
                }
            }
        }

        return null;
    }

    private static BaseModelClass? GetObjectFromHashTable(Dictionary<string, object> hashTable)
    {
        // Create the needed object
        if (!hashTable.ContainsKey("type"))
        {
            throw new Spdx3Exception("No type found in hash table");
        }
        var t = (string)hashTable["type"];
        var classTypeName = Naming.ClassNameForSpdxType(t);
        var classType = Type.GetType(classTypeName);
        if (classType == null)
        {
            throw new Spdx3Exception($"Could not determine classtype for {classTypeName}");
        }

        if (classType.IsAbstract)
        {
            throw new Spdx3Exception($"{classTypeName} is an abstract class and cannot be instantiated");
        }
        var result = (BaseModelClass)Activator.CreateInstance(classType, true);
        
        // Populate the object with values
        foreach (var entry in hashTable)
        {
            var key = entry.Key;
            if (key == "@id")
            {
                key = "spdxId";
            }
            if (key == "@type")
            {
                key = "type";
            }
            var property = GetPropertyFromJsonElementName(classType, key);
            if (property == null)
            {
                throw new Spdx3SerializationException($"Property for {key} on class {classType} could not be found.");
            }
            
            if (property.PropertyType.IsAssignableTo(typeof(BaseModelClass)))
            {
                var placeHolder = GetPlaceHolder(property, (string)entry.Value);
                property.SetValue(result, placeHolder);
            }
            else if (property.PropertyType == typeof(string))
            {
                property.SetValue(result, entry.Value);
            }
            else if (property.PropertyType == typeof(int))
            {
                property.SetValue(result, Int32.Parse((string)entry.Value));
            }
            else if (property.PropertyType == typeof(DateTimeOffset))
            {
                property.SetValue(result, DateTimeOffset.Parse((string)entry.Value));
            }
            else if (property.PropertyType.IsGenericType &&
                     property.PropertyType.GetGenericTypeDefinition() == typeof(IList<>) &&
                     property.PropertyType.GetGenericArguments()[0].IsAssignableTo(typeof(BaseModelClass)))
            {
                var l  = property.GetValue(result);
                var listOfObjects = l as IList;
                if (listOfObjects == null)
                {
                    throw new Spdx3SerializationException($"Could not get list of objects for type {property.PropertyType}");
                }

                List<object>? listOfIds;
                if (entry.Value is string)
                {
                    listOfIds = new List<object>();
                    listOfIds.Add(entry.Value);
                }
                else
                {
                    listOfIds = (entry.Value as List<object>);
                    if (listOfIds == null)
                    {
                        throw new Spdx3SerializationException($"Could not get list of ID's from hashtable");
                    }
                }

                foreach (var id in listOfIds)
                {
                    var placeholder = GetPlaceHolder(property, (string)id);    
                    listOfObjects.Add(placeholder);
                }
                
            }
            else if (property.PropertyType.IsGenericType &&
                     property.PropertyType.GetGenericTypeDefinition() == typeof(IList<>) &&
                     property.PropertyType.GetGenericArguments()[0].IsEnum)
            {
                if (entry.Value == null)
                {
                    throw new Spdx3SerializationException($"Could not get value of type {property.PropertyType}");
                }
                var enumType = property.PropertyType.GetGenericArguments()[0];
                
                var listOfEnums = (property.GetValue(result) as IList);
                if (listOfEnums == null)
                {
                    throw new Spdx3SerializationException($"Could not get value of type {property.PropertyType} as a list");
                }

                foreach (var id in entry.Value as IList<object>)
                {
                    var value = Enum.Parse(enumType, (string)id); 
                    listOfEnums.Add(value);
                }
                
                
            }
            else if (property.PropertyType.IsEnum)
            {
                var value = Enum.Parse(property.PropertyType, (string)entry.Value);
                property.SetValue(result, value);
            }
            else if (property.PropertyType.IsGenericType &&
                     property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) &&
                     property.PropertyType.GetGenericArguments()[0].IsEnum)
            {
                var value = Enum.Parse(property.PropertyType.GetGenericArguments()[0], (string)entry.Value);
                property.SetValue(result, value);
            }
            else
            {
                throw new Spdx3SerializationException("No handler for property");
            }
        }
        
        return result;
    }

    private static BaseModelClass GetPlaceHolder(PropertyInfo property, string spdxId)
    {
        var propType = property.PropertyType;
        if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(IList<>))
        {
            propType = propType.GetGenericArguments()[0];
        }

        if (propType.IsAbstract)
        {
            var placeHolderClassName = Regex.Replace(propType.FullName, @"\.Classes\.", ".Classes.Placeholder");
            propType = Type.GetType(placeHolderClassName);
            if (propType == null)
            {
                throw new Spdx3Exception($"Could not determine placeholder class type for {property.PropertyType.FullName}");
            }
        }
        
        var placeHolder = NewPlaceHolderWithId(propType, spdxId);
        return placeHolder;
    }

    private static BaseModelClass NewPlaceHolderWithId(Type propType, string? id)
    {
        var placeHolder = (BaseModelClass)Activator.CreateInstance(propType, true);
        placeHolder.Type = Naming.SpdxTypeForClass(propType);
        placeHolder.SpdxId = id;
        if (placeHolder is Element)
        {
            (placeHolder as Element).Comment = "***Placeholder***";
        }

        return placeHolder;
    }
}