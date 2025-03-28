using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model;
using Spdx3.Utility;
using Uri = System.Uri;

namespace Spdx3.Serialization;

public class SpdxModelConverter<T> : JsonConverter<T>
{
    /// <summary>
    /// The main Read method implementation for this implementation of a JsonConverter
    /// </summary>
    /// <param name="reader">The JSON reader</param>
    /// <param name="typeToConvert">The type we're trying/expecting to construct from the JSON</param>
    /// <param name="options">Options for the converter</param>
    /// <returns>The constructed instance read from the JSON</returns>
    /// <exception cref="Spdx3SerializationException">If something specific to SPDX3 goes wrong</exception>
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = (T?)Activator.CreateInstance(typeToConvert, true) ??
                     throw new Spdx3SerializationException($"Could not create instance of {typeToConvert}");
        PropertyInfo? currentProperty = null;

        while (reader.Read())
            switch (reader.TokenType)
            {
                case JsonTokenType.PropertyName:
                    var newPropName = reader.GetString() ??
                                      throw new Spdx3SerializationException("Couldn't read property name");
                    currentProperty = GetPropertyFromJsonElementName(typeToConvert, newPropName);
                    break;

                case JsonTokenType.StartObject:
                    Debug.Assert(currentProperty == null,
                        $"There should not be nested objects in {currentProperty?.Name}");
                    break;

                case JsonTokenType.String:
                    LoadJsonStringIntoProperty(result, currentProperty,
                        reader.GetString() ?? throw new Spdx3SerializationException("Couldn't read string"));

                    break;
                case JsonTokenType.Number:
                    if (currentProperty?.PropertyType == typeof(int))
                    {
                        var intVal = reader.GetInt32();
                        (currentProperty ?? throw new Spdx3SerializationException("No current property")).SetValue(
                            result,
                            intVal);
                    }
                    else
                    {
                        var dblVal = reader.GetDouble();
                        (currentProperty ?? throw new Spdx3SerializationException("No current property")).SetValue(
                            result,
                            dblVal);
                    }

                    break;
            }

        return result;
    }

    /// <summary>
    /// Take a given string value just read from the JSON, and load its value into whatever the property is that we're currently reading.
    /// </summary>
    /// <param name="result">The object with the property</param>
    /// <param name="currentProperty">The property of the object that we're loading into</param>
    /// <param name="strVal">The string value</param>
    /// <exception cref="Spdx3SerializationException">If something specific to SPDX3 goes wrong</exception>
    private void LoadJsonStringIntoProperty(object result, PropertyInfo? currentProperty, string strVal)
    {
        Debug.Assert(currentProperty != null, $"There is no current property to receive for value {strVal}");

        if (currentProperty.PropertyType == typeof(string))
        {
            currentProperty.SetValue(result, strVal);
        }
        else if (currentProperty.PropertyType == typeof(Uri))
        {
            currentProperty.SetValue(result, new Uri(strVal));
        }
        else if (currentProperty.PropertyType == typeof(DateTimeOffset))
        {
            currentProperty.SetValue(result, DateTimeOffset.Parse(strVal));
        }
        else if (currentProperty.PropertyType.IsEnum)
        {
            currentProperty.SetValue(result, Enum.Parse(currentProperty.PropertyType, strVal));
        }
        else if (currentProperty.PropertyType.IsGenericType)
        {
            var genericType = currentProperty.PropertyType.GetGenericArguments()[0];
            if (genericType.IsEnum && currentProperty.GetValue(result) is IList enumList)
            {
                enumList.Add(Enum.Parse(genericType, strVal));
            }
            else if (genericType.IsEnum)
            {
                currentProperty.SetValue(result, Enum.Parse(genericType, strVal));
            }
            else if (genericType == typeof(bool))
            {
                currentProperty.SetValue(result, bool.Parse(strVal));
            }
            else if (genericType == typeof(string) && currentProperty.GetValue(result) is IList strList)
            {
                strList.Add(strVal);
            }
            else if (genericType == typeof(DateTimeOffset) && currentProperty.GetValue(result) is IList dateTimeOffsetList)
            {
                dateTimeOffsetList.Add(DateTimeOffset.Parse(strVal));
            }
            else if (genericType == typeof(DateTimeOffset))
            {
                currentProperty.SetValue(result, DateTimeOffset.Parse(strVal));
            }
            else if (genericType.IsAssignableTo(typeof(BaseModelClass)))
            {
                /*
                 * At this point we have a string that is the URN of another Element, which we may or may not
                 * have read yet.  For now, make a placeholder element of the type needed and the ID in the json.
                 * Later, we're going to need to go through the objects and replace the placeholder with the real one.
                 */
                var placeHolderType = genericType;
                if (placeHolderType.IsAbstract)
                {
                    var nm = placeHolderType.FullName?.Replace("Spdx3.Model.", "Spdx3.Tests.Model.") + "ConcreteTestFixture";
                    if (Type.GetType(nm) != null)
                    {
                        placeHolderType = Type.GetType(nm);
                    }
                }
                var placeHolder =
                    Convert.ChangeType(Activator.CreateInstance(placeHolderType, true), genericType) ??
                    throw new Spdx3SerializationException($"Could not create instance of {genericType}");
                var type = placeHolder.GetType();
                var spdxIdProperty = type.GetProperty("SpdxId") ??
                                     throw new Spdx3SerializationException("Could not get spdxId property");
                spdxIdProperty.SetValue(placeHolder, new Uri(strVal));

                var typeProperty = type.GetProperty("Type") ??
                                   throw new Spdx3SerializationException("Could not get type property");
                typeProperty.SetValue(placeHolder, Naming.SpdxTypeForClass(genericType));
                if (currentProperty.GetValue(result) is not IList listVal)
                {
                    throw new Spdx3SerializationException(
                        $"List property {currentProperty.Name} was not initialized as a list");
                }

                listVal.Add(placeHolder);
            }
            else
            {
                throw new Spdx3SerializationException($"The type {genericType} is not supported");
            }
        }
        else if (currentProperty.PropertyType.IsEnum)
        {
            currentProperty.SetValue(result, Enum.Parse(currentProperty.PropertyType, strVal));
        }
        else if (currentProperty.PropertyType.IsSubclassOf(typeof(BaseModelClass)))
        {
            /*
             * At this point we have a string that is the URN of another Element, which we may or may not
             * have read yet.  For now, make a placeholder element of the type needed and the ID in the json.
             * Later, we're going to need to go through the objects and replace the placeholder with the real one.
             */
            var placeHolder = Convert.ChangeType(Activator.CreateInstance(currentProperty.PropertyType, true),
                currentProperty.PropertyType);
            currentProperty.PropertyType.GetProperty("SpdxId")?.SetValue(placeHolder, new Uri(strVal));
            currentProperty.PropertyType.GetProperty("Type")?.SetValue(placeHolder,
                Naming.SpdxTypeForClass(currentProperty.PropertyType));
            currentProperty.SetValue(result, placeHolder);
        }
        else
        {
            throw new Spdx3SerializationException($"No string handler for a {currentProperty.PropertyType.Name}");
        }
    }

    /// <summary>
    /// The main Write operation for this implementation of the JsonConverter
    /// </summary>
    /// <param name="writer">The writer we are writing to</param>
    /// <param name="value">The value we're writing</param>
    /// <param name="options">The options for the JsonSerializer</param>
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            return;
        }

        var props = value.GetType().GetProperties()
            .Where(prop => Attribute.IsDefined(prop, typeof(JsonPropertyNameAttribute)));

        writer.WriteStartObject();

        foreach (var prop in props.Where(prop => prop.GetValue(value) != null))
        {
            var jsonElementName = GetJsonElementNameFromPropertyAttribute(prop);

            var propType = prop.PropertyType;
            var propVal = prop.GetValue(value);

            // If it's a list of OTHER SpdxClasses, don't serialize the objects, just serialize an array of references
            if (propType.IsGenericType)
            {
                if (propType.GenericTypeArguments[0].IsSubclassOf(typeof(BaseModelClass)) &&
                    propVal is IList spdxClasses)
                {
                    if (spdxClasses.Count > 0)
                    {
                        WriteReferencesToListItems(writer, spdxClasses, jsonElementName);
                    }

                    continue;
                }

                // If it's a list of Enum values, serialize the names of the values
                if (propType.GenericTypeArguments[0].IsEnum &&
                    propVal is IList enums)
                {
                    if (enums.Count > 0)
                    {
                        WriteReferencesToEnumValues(writer, propType.GenericTypeArguments[0], enums, jsonElementName);
                    }

                    continue;
                }
            }

            WriteSimpleProperty(writer, propVal, jsonElementName);
        }


        writer.WriteEndObject();
    }

    private static void WriteSimpleProperty(Utf8JsonWriter writer, object? propVal, string jsonElementName)
    {
        switch (propVal)
        {
            case Enum:
                writer.WriteString(jsonElementName, Enum.GetName(propVal.GetType(), propVal));
                break;
            case int val:
                writer.WriteNumber(jsonElementName, val);
                break;
            case double val:
                writer.WriteNumber(jsonElementName, val);
                break;
            case bool val:
                writer.WriteBoolean(jsonElementName, val);
                break;
            case Uri val:
                writer.WriteString(jsonElementName, val.ToString());
                break;
            case DateTimeOffset val:
                writer.WriteString(jsonElementName, val.UtcDateTime.ToString("yyyy-MM-ddTHH:mm:ssZ"));
                break;
            case string val:
                writer.WriteString(jsonElementName, val);
                break;
            case BaseModelClass:
                writer.WriteString(jsonElementName, (string)(propVal as dynamic).SpdxId.ToString());
                break;
            case List<string> list:
                if (list.Count > 0)
                {
                    writer.WritePropertyName(jsonElementName);
                    writer.WriteStartArray();
                    list.ForEach(writer.WriteStringValue);
                    writer.WriteEndArray();
                }

                break;
            case List<Uri> list:
                if (list.Count > 0)
                {
                    writer.WritePropertyName(jsonElementName);
                    writer.WriteStartArray();
                    list.ForEach(u => writer.WriteStringValue(u.ToString()));
                    writer.WriteEndArray();
                }

                break;
            default:
                throw new Spdx3Exception($"Unhandled class type {propVal?.GetType().FullName}");
        }
    }

    private static void WriteReferencesToListItems(Utf8JsonWriter writer, IList spdxClasses, string jsonElementName)
    {
        writer.WritePropertyName(jsonElementName);
        writer.WriteStartArray();
        foreach (var spdxClass in spdxClasses)
        {
            if (spdxClass != null)
            {
                writer.WriteStringValue((spdxClass as BaseModelClass)?.SpdxId.ToString());
            }
        }

        writer.WriteEndArray();
    }

    private static void WriteReferencesToEnumValues(Utf8JsonWriter writer, Type enumType, IList enumValues,
        string jsonElementName)
    {
        writer.WritePropertyName(jsonElementName);
        writer.WriteStartArray();
        foreach (var enumValue in enumValues)
        {
            if (enumValue != null)
            {
                writer.WriteStringValue(Enum.GetName(enumType, enumValue));
            }
        }

        writer.WriteEndArray();
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


    private static PropertyInfo GetPropertyFromJsonElementName(Type typeToConvert, string elementName)
    {
        foreach (var prop in typeToConvert.GetProperties())
        {
            foreach (var propAttr in prop.GetCustomAttributes())
            {
                if (propAttr is JsonPropertyNameAttribute && elementName == (propAttr as dynamic).Name)
                {
                    return prop;
                }
            }
        }

        throw new Spdx3SerializationException(
            $"Unable to get property on {typeToConvert.Name} for JSON element named {elementName}");
    }
}