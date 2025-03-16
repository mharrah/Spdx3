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

internal partial class SpdxWrapperConverter<T> : JsonConverter<T>
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeof(T) != typeof(PhysicalSerialization))
        {
            throw new Spdx3SerializationException($"Can only read classes of type {typeof(PhysicalSerialization)} ");
        }

        var result = (T?)Activator.CreateInstance(typeToConvert, true);
        AssertNotNull(result, $"Could not create instance of type {typeof(T)}");
        

        // We keep a hashtable of values of objects in the @graph array as we read them, and then turn each 
        // hashtable into an SpdxBaseClass object from the model
        Dictionary<string, object>? hashTable = null;
        
        // As we read the object properties, first we read the name, then we read the value.  This is the name and
        // the key into the hashtable that we're about to set.
        var hashTableKey = string.Empty;
        
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
                    AssertNotNull(hashTableKey , "Expected a property name but got null value");

                    break;

                case JsonTokenType.String:
                    var strVal = reader.GetString();
                    Console.WriteLine($"String value: '{strVal}'");

                    if (reader.CurrentDepth < 2)
                    {
                        // This must be the @context or the @graph, in which case there's nothing to do
                        continue;
                    }

                    AssertNotNull(strVal, $"Null value encountered for string value for {hashTableKey}"); 
                    AssertNotNull(hashTable, "Not expecting a value at this point");
                    
                    if (currentArray == null) {
                        AssertNotNull(hashTableKey, $"No hashtable key for value {strVal}");

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

                    AssertNotNull(hashTable, "Not expecting a value at this point");

                    if (currentArray == null)
                    {
                        AssertNotNull(hashTableKey, $"No hashtable key for value {intVal}");

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

                    AssertNotNull(hashTable, "End of array but not in a property value");

                    hashTable[hashTableKey] = currentArray ?? throw new Spdx3SerializationException("End of array but no array value available");
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
                    AssertNotNull(hashTable, "End of object but no hashtable of values available");
                    
                    var cls = GetObjectFromHashTable(hashTable);
                    AssertNotNull(cls, "Unable to get an Spdx class from properties of object");
                    
                    (result as PhysicalSerialization)?.Graph.Add(cls);
                    hashTable = null;
                    break;

                case JsonTokenType.None:
                case JsonTokenType.Comment:
                case JsonTokenType.True:
                case JsonTokenType.False:
                case JsonTokenType.Null:
                default:
                    throw new Spdx3SerializationException($"Unexpected token type {reader.TokenType}");
            }
        }

        return result;
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        AssertNotNull(value, "Value cannot be null.");

        var props = value.GetType().GetProperties();

        writer.WriteStartObject();

        foreach (var prop in props.Where(prop => prop.GetValue(value) != null))
        {
            var jsonElementName = GetJsonElementNameFromPropertyAttribute(prop);

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
        var eName = RegexSpdxDomainSlash().Replace(elementName, "");
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
        if (!hashTable.TryGetValue("type", out var val))
        {
            throw new Spdx3Exception("No type found in hash table");
        }
        var t = (string)val;
        var classTypeName = Naming.ClassNameForSpdxType(t);
        var classType = Type.GetType(classTypeName);
        AssertNotNull(classType, $"Could not determine class type for {classTypeName}");

        if (classType.IsAbstract)
        {
            throw new Spdx3Exception($"{classTypeName} is an abstract class and cannot be instantiated");
        }
        var result = Activator.CreateInstance(classType, true) as BaseModelClass;
        
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
            AssertNotNull(property, $"Property for {key} on class {classType} could not be found.");

            var propType = property.PropertyType;
            if (propType.IsAssignableTo(typeof(BaseModelClass)))
            {
                var placeHolder = GetPlaceHolder(property, (string)entry.Value);
                property.SetValue(result, placeHolder);
            }
            else if (propType == typeof(string))
            {
                property.SetValue(result, entry.Value);
            }
            else if (propType == typeof(int))
            {
                property.SetValue(result, int.Parse((string)entry.Value));
            }
            else if (propType == typeof(DateTimeOffset))
            {
                property.SetValue(result, DateTimeOffset.Parse((string)entry.Value));
            }
            else if (propType.IsGenericType)
            {
                if ( propType.GetGenericTypeDefinition() == typeof(IList<>) &&
                     propType.GetGenericArguments()[0].IsAssignableTo(typeof(BaseModelClass)))
                {
                    var l  = property.GetValue(result);
                    if (l is not IList listOfObjects)
                    {
                        throw new Spdx3SerializationException($"Could not get list of objects for type {propType}");
                    }

                    List<object>? listOfIds;
                    if (entry.Value is string)
                    {
                        listOfIds = [];
                    }
                    else
                    {
                        listOfIds = entry.Value as List<object>;
                        AssertNotNull(listOfIds, "Could not get list of ID's from hashtable");
                    }

                    foreach (var placeholder in listOfIds.Select(id => GetPlaceHolder(property, (string)id)))
                    {
                        listOfObjects.Add(placeholder);
                    }
                    
                }
                else if (propType.GetGenericTypeDefinition() == typeof(IList<>) &&
                         propType.GetGenericArguments()[0].IsEnum)
                {
                    AssertNotNull(entry.Value, $"Could not get value of type {propType}");

                    var enumType = propType.GetGenericArguments()[0];

                    if (property.GetValue(result) is not IList listOfEnums)
                    {
                        throw new Spdx3SerializationException(
                            $"Could not get value of type {propType} as a list");
                    }

                    foreach (var id in (IList<object>)entry.Value)
                    {
                        var value = Enum.Parse(enumType, (string)id);
                        listOfEnums.Add(value);
                    }
                }
                else if (propType.GetGenericTypeDefinition() == typeof(Nullable<>) &&
                         propType.GetGenericArguments()[0].IsEnum)
                {
                    var value = Enum.Parse(propType.GetGenericArguments()[0], (string)entry.Value);
                    property.SetValue(result, value);
                }
            }
            else if (propType.IsEnum)
            {
                var value = Enum.Parse(propType, (string)entry.Value);
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
            var placeHolderClassName = RegexClassesNamespaceSegment()
                .Replace(propType.FullName ?? 
                         throw new Spdx3SerializationException($"Could not determine full name of property type {propType}"),
                    ".Classes.Placeholder");
            propType = Type.GetType(placeHolderClassName);
            AssertNotNull(propType, $"Could not determine placeholder class type for {property.PropertyType.FullName}");
        }
        
        var placeHolder = NewPlaceHolderWithId(propType, spdxId);
        return placeHolder;
    }

    private static BaseModelClass NewPlaceHolderWithId(Type propType, string id)
    {
        if (Activator.CreateInstance(propType, true) is not BaseModelClass placeHolder)
        {
            throw new Spdx3Exception($"Could not create placeholder for {propType.FullName}");
        }
        placeHolder.Type = Naming.SpdxTypeForClass(propType);
        placeHolder.SpdxId = id;
        if (placeHolder is Element element)
        {
            element.Comment = "***Placeholder***";
        }

        return placeHolder;
    }

    // Null check to make code a bit terser and more expressive
    private static void AssertNotNull(object? obj, string messageIfNull)
    {
        if (obj == null)
        {
            throw new Spdx3SerializationException(messageIfNull);
        }
    }

    [GeneratedRegex("^spdx:.*/")]
    private static partial Regex RegexSpdxDomainSlash();
    
    
    [GeneratedRegex(@"\.Classes\.")]
    private static partial Regex RegexClassesNamespaceSegment();
}