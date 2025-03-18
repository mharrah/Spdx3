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

/// <summary>
/// This is the JsonConvertoo for the SpdxWrapper object
/// </summary>
/// <typeparam name="T"></typeparam>
internal class SpdxWrapperConverter<T> : JsonConverter<T>
{
    // We keep a hashtable of values of objects in the @graph array as we read them, and then turn each 
    // hashtable into an SpdxBaseClass object from the model
    private Dictionary<string, object>? _hashTable;

    // As we read the object properties, first we read the name, then we read the value.  This is the name and
    // the key into the hashtable that we're about to set.
    private string _currentHashTableKey = string.Empty;
    
    // This array is for when the value of a hashTable entry is an array of values
    private List<object>? _currentValueArray;
    
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new SpdxWrapper(); 

        while (reader.Read())
        {
            // The outer layers are not of interest, so just keep going until we get deeper in the structure
            if (reader.CurrentDepth < 2)
            {
                continue;
            }

            switch (reader.TokenType)
            {
                case JsonTokenType.PropertyName:
                    _currentHashTableKey = reader.GetString() ?? throw new Spdx3SerializationException("Property name was null");
                    break;

                case JsonTokenType.String:
                    var strVal = reader.GetString() ?? throw new Spdx3SerializationException("String value is null");

                    if (_currentValueArray == null)
                    {
                        // Not in an array, so the string value goes directly into the property
                        SetHashtableValue(strVal);
                    }
                    else
                    {
                        // In an array, so the string value goes into the array
                        _currentValueArray.Add(strVal);
                    }

                    break;

                case JsonTokenType.Number:
                    var intVal = reader.GetInt32();

                    if (_currentValueArray == null)
                    {
                        // Not in an array, so the int value goes directly into the property
                        SetHashtableValue(intVal);
                    }
                    else
                    {
                        // We're in an array, so the int value goes in the array
                        _currentValueArray.Add(intVal);
                    }

                    break;


                case JsonTokenType.StartArray:
                    // If we already have an array in progress, we are nesting, and we can't do that (yet?)
                    if (_currentValueArray != null)
                    {
                        throw new Spdx3SerializationException("Can't process nested array values");
                    }

                    // Start the new array
                    _currentValueArray = [];
                    break;

                case JsonTokenType.EndArray:
                    // The array is over, set the hashtable property to the array value
                    SetHashtableValue(_currentValueArray);
                    _currentValueArray = null;  // Get rid of the array buffer
                    break;

                case JsonTokenType.StartObject:
                    // There shouldn't be a hashtable already in progress at the start of a new object
                    if (_hashTable != null)
                    {
                        throw new Spdx3SerializationException("Can't process nested object values");
                    }

                    // Start a new hashtable for holding values -- we'll make a model object out of it when we reach the end of the json object
                    _hashTable = new Dictionary<string, object>();

                    break;

                case JsonTokenType.EndObject:
                    // Turn the hashtable into Spdx class
                    var cls = GetObjectFromHashTable();
                    result.Graph.Add(cls);
                    _hashTable = null;  // Get rid of the hashTable so we can safely start a new one
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

        return (T)Convert.ChangeType(result, typeToConvert);
    }

    private void SetHashtableValue(object? value)
    {
        if (_hashTable == null) throw new Spdx3SerializationException("Hash table is null");
        if (_currentHashTableKey == null) throw new Spdx3SerializationException("Current hash table key is null");
        _hashTable[_currentHashTableKey] = value ?? throw new Spdx3SerializationException("Value is null");
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        var props = value?.GetType().GetProperties()
                    ?? throw new Spdx3SerializationException("Could not get properties of value to write");

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

    /// <summary>
    ///     Given a property on a Model class, get its json element name (i.e., the value in the JsonPropertyName attribute).
    /// </summary>
    /// <param name="prop">The property of an object</param>
    /// <returns>The string value of the JsonPropertyName for that property</returns>
    private static string GetJsonElementNameFromPropertyAttribute(PropertyInfo prop)
    {
        var jsonPropertyAttribute = prop.GetCustomAttributes().FirstOrDefault(a => a is JsonPropertyNameAttribute);
        return jsonPropertyAttribute != null ? (string)(jsonPropertyAttribute as dynamic).Name : string.Empty;
    }

    /// <summary>
    ///     Given a property name from a JSON element, derive the Object property it represents (along with all its type
    ///     info).
    ///     These correspond to the JsonPropertyNames of the properties in the Model classes.
    ///     For example, if the current object is an Annotation, and the json element name is "annotationType", this
    ///     corresponds to the AnnotationType property on the Annotation object (which is what is returned), and it is of type
    ///     AnnotationType (the enum).
    /// </summary>
    /// <param name="typeToConvert">The object that has the property</param>
    /// <param name="elementName">The name of the property as found in the JSON file (e.g., "build_buildId")</param>
    /// <returns>The property info, or null if no match</returns>
    private static PropertyInfo GetPropertyFromJsonElementName(Type typeToConvert, string elementName)
    {
        var eName = Regex.Replace(elementName, "^spdx:.*/", "");
        foreach (var prop in typeToConvert.GetProperties())
        {
            var jsonPropertyAttribute = prop.GetCustomAttributes().FirstOrDefault(a => a is JsonPropertyNameAttribute);
            if (jsonPropertyAttribute == null)
            {
                // This property didn't have
                continue;
            }
            if (eName == (jsonPropertyAttribute as dynamic).Name)
            {
                return prop;
            }
        }

        throw new Spdx3SerializationException($"Could not find a property with JsonPropertyNameAttribute matching {eName} on {typeToConvert.Name}");
    }

    /// <summary>
    /// From the hashtable of values in the JSON, construct a model object with those values (for primitives) or placeholders (for objects)
    /// </summary>
    /// <returns>A partially constructed object from the hashtable values</returns>
    /// <exception cref="Spdx3SerializationException"></exception>
    /// <exception cref="Spdx3Exception"></exception>
    private BaseModelClass GetObjectFromHashTable()
    {
        if (_hashTable == null)
        {
            throw new Spdx3SerializationException("Hash table is null");
        }
        
        // Create the needed object
        if (!_hashTable.TryGetValue("type", out var val))
        {
            throw new Spdx3Exception("No type found in hash table");
        }

        var t = (string)val;
        var classTypeName = Naming.ClassNameForSpdxType(t);
        var classType = Type.GetType(classTypeName) ??
                        throw new Spdx3SerializationException($"Could not get type {classTypeName}");

        if (classType.IsAbstract)
        {
            throw new Spdx3Exception($"{classTypeName} is an abstract class and cannot be instantiated");
        }

        var result = Activator.CreateInstance(classType, true) as BaseModelClass
                     ?? throw new Spdx3SerializationException($"Unable to instantiate instance of {classTypeName}");

        // Populate the object with values
        foreach (var entry in _hashTable)
        {
            var key = Regex.Replace(entry.Key, "^spdx:.*/", "");
            if (key == "@id")
            {
                key = "spdxId";
            }

            if (key == "@type")
            {
                key = "type";
            }

            var property = GetPropertyFromJsonElementName(classType, key);
            var propType = property.PropertyType;
            if (propType.IsAssignableTo(typeof(BaseModelClass)))
            {
                var placeHolder = GetPlaceHolderForProperty(property, (string)entry.Value);
                property.SetValue(result, placeHolder);
            }
            else if (propType == typeof(string) || propType == typeof(int))
            {
                property.SetValue(result, entry.Value);
            }
            else if (propType == typeof(DateTimeOffset))
            {
                property.SetValue(result, DateTimeOffset.Parse((string)entry.Value));
            }
            else if (propType.IsGenericType)
            {
                if (propType.GetGenericTypeDefinition() == typeof(IList<>) &&
                    propType.GetGenericArguments()[0].IsAssignableTo(typeof(BaseModelClass)))
                {
                    // The property is a list of classes, but the Json just has a list of references.
                    // We need to create placeholder objects from the ID's that we will swap out later
                    var l = property.GetValue(result);
                    if (l is not IList propertyValueListOfObjects)
                    {
                        throw new Spdx3SerializationException($"Could not get list of objects for type {propType}");
                    }

                    List<object> listOfIds;
                    if (entry.Value is string)
                    {
                        listOfIds = [];
                    }
                    else
                    {
                        listOfIds = entry.Value as List<object> ??
                                    throw new Spdx3SerializationException("List of ID's is null");
                    }

                    foreach (var placeholder in listOfIds.Select(id => GetPlaceHolderForProperty(property, (string)id)))
                    {
                        propertyValueListOfObjects.Add(placeholder);
                    }
                }
                else if (propType.GetGenericTypeDefinition() == typeof(IList<>) &&
                         propType.GetGenericArguments()[0].IsEnum)
                {
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
            else if (propType == typeof(Uri))
            {
                property.SetValue(result, new Uri((string)entry.Value));
            }
            else
            {
                throw new Spdx3SerializationException("No handler for property");
            }
        }

        return result;
    }

    /// <summary>
    ///     Create a placeholder object for the current property, with a specific ID - we'll replace the object later
    /// </summary>
    /// <param name="property">The property (of some other object) that we need a placeholder for</param>
    /// <param name="spdxId">The ID to give that placeholder so we can find its replacement later</param>
    /// <returns>A minimally populated instance of a class that is the type the property needs, with the ID set</returns>
    /// <exception cref="Spdx3SerializationException">Any of a variety of things went wrong</exception>
    private static BaseModelClass GetPlaceHolderForProperty(PropertyInfo property, string spdxId)
    {
        var propType = property.PropertyType ??
                       throw new Spdx3SerializationException($"Could not determine type of property {property}");
        if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(IList<>))
        {
            propType = propType.GetGenericArguments()[0]
                       ?? throw new Spdx3SerializationException(
                           $"Could not determine generic argument of type {propType}");
        }

        if (propType.IsAbstract)
        {
            var placeHolderClassName = Regex.Replace(propType.FullName ??
                                                     throw new Spdx3SerializationException(
                                                         $"Could not determine full name of property type {propType}"),
                @"\.Classes\.",
                ".Classes.Placeholder");
            propType = Type.GetType(placeHolderClassName)
                       ?? throw new Spdx3SerializationException($"Could not get type {placeHolderClassName}");
        }

        var placeHolder = NewPlaceHolderObjectWithId(propType, spdxId);
        return placeHolder;
    }


    /// <summary>
    ///     Factory method to return a placeholder of a specific type, with the required ID.
    ///     This method differs from using a constructor in that it does not require all the fields required to pass
    ///     validation, and it also does not add the new item to the Catalog.
    /// </summary>
    /// <param name="propType">The type of the placeholder needed</param>
    /// <param name="id">The ID of the placeholder</param>
    /// <returns>A new placeholder object of the specified type.</returns>
    /// <exception cref="Spdx3Exception"></exception>
    private static BaseModelClass NewPlaceHolderObjectWithId(Type propType, string id)
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
}