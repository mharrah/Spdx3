using System.Collections;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model;
using Spdx3.Utility;

namespace Spdx3.Serialization;

internal class SpdxObjectConvertor<T> : JsonConverter<T>
{
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Console.WriteLine($"Creating a {typeToConvert}");
        var result = (T?)Activator.CreateInstance(typeToConvert, true);
        Console.WriteLine($"TokenType={reader.TokenType}");
        PropertyInfo? currentProp = null;
        while (reader.Read())
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    Console.WriteLine($"TokenType={reader.TokenType}");
                    throw new Spdx3SerializationException($"There should not be nested objects in {currentProp?.Name}");
                    break;
                case JsonTokenType.EndObject:
                    Console.WriteLine($"TokenType={reader.TokenType}");
                    break;
                case JsonTokenType.StartArray:
                    Console.WriteLine($"TokenType={reader.TokenType}");
                    // The list should already be initialized on the property
                    break;
                case JsonTokenType.EndArray:
                    Console.WriteLine($"TokenType={reader.TokenType}");
                    break;
                case JsonTokenType.String:
                    var strVal = reader.GetString();
                    Console.WriteLine($"TokenType=String Value={strVal}");
                    if (currentProp == null)
                    {
                        throw new Spdx3SerializationException($"No current property to hold string value {strVal}");
                    }

                    if (currentProp.PropertyType == typeof(string))
                    {
                        currentProp.SetValue(result, strVal);
                    }
                    else if (currentProp.PropertyType == typeof(DateTimeOffset))
                    {
                        currentProp.SetValue(result, DateTimeOffset.Parse(strVal));
                    }
                    else if (currentProp.PropertyType.IsGenericType) 
                    {
                        if (currentProp.PropertyType == typeof(IList<string>))
                        {
                            ((IList)currentProp.GetValue(result)).Add(strVal);
                        }
                        else
                        {
                            throw new NotImplementedException($"Generic type {currentProp.PropertyType} not handled");
                        }
                    }
                    else if (currentProp.PropertyType.IsEnum)
                    {
                        currentProp.SetValue(result, Enum.Parse(currentProp.PropertyType, strVal));
                    }
                    else if (currentProp.PropertyType.IsSubclassOf(typeof(BaseSpdxClass)))
                    {
                        /*
                         * At this point we have a string that is the URN of another Element, which we may or may not
                         * have read yet.  For now, make a placeholder element of the type needed and the ID in the json.
                         * Later, we're going to need to go through the objects and replace the placeholder with the real one.
                         */
                        var placeHolder = Convert.ChangeType(Activator.CreateInstance(currentProp.PropertyType, true), currentProp.PropertyType);
                        placeHolder.GetType().GetProperty("SpdxId").SetValue(placeHolder, strVal);
                        placeHolder.GetType().GetProperty("Type").SetValue(placeHolder, SpdxUtility.SpdxTypeForClass(currentProp.PropertyType));
                        currentProp.SetValue(result, placeHolder);
                    }
                    else
                    {
                        throw new NotImplementedException($"No handler for string for a {currentProp.PropertyType.Name}");
                    }

                    break;
                case JsonTokenType.Number:
                    var intVal = reader.GetInt32();
                    Console.WriteLine($"TokenType=Number Value={intVal}");
                    if (currentProp == null)
                    {
                        throw new Spdx3SerializationException($"No current property to hold int value {intVal}");
                    }

                    currentProp.SetValue(result, intVal);

                    break;
                case JsonTokenType.PropertyName:
                    var currentPropName = reader.GetString();
                    Console.WriteLine($"TokenType=PropertyName Value={currentPropName}");
                    currentProp = GetPropertyAttributeFromJsonElementName(typeToConvert, currentPropName);
                    if (currentProp == null)
                    {
                        throw new Spdx3SerializationException(
                            $"Property {currentPropName} is not found on type {typeToConvert}");
                    }

                    break;
            }

        return result;
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            return;
        }

        // Otherwise, we need to serialize all the properties
        var props = value.GetType().GetProperties()
            .Where(prop => Attribute.IsDefined(prop, typeof(JsonPropertyNameAttribute)));

        writer.WriteStartObject();

        foreach (var prop in props.Where(prop => prop.GetValue(value) != null))
        {
            var jsonElementName = GetJsonElementNameFromPropertyAttribute(prop);

            var propType = prop.PropertyType;
            var propVal = prop.GetValue(value);

            // If it's a list of OTHER SpdxClasses, don't serialize the objects, just serialize an array of references
            if (propType.IsGenericType &&
                propType.GenericTypeArguments[0].IsSubclassOf(typeof(BaseSpdxClass)) &&
                propVal is IList spdxClasses)
            {
                if (spdxClasses.Count > 0)
                {
                    WriteReferencesToListItems(writer, spdxClasses, jsonElementName);
                }

                continue;
            }

            // If it's a list of Enum values, serialize the names of the values
            if (propType.IsGenericType &&
                propType.GenericTypeArguments[0].IsEnum &&
                propVal is IList enums)
            {
                if (enums.Count > 0)
                {
                    WriteReferencesToEnumValues(writer, propType.GenericTypeArguments[0], enums, jsonElementName);
                }

                continue;
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
            case string val:
                writer.WriteString(jsonElementName, val);
                break;
            case DateTimeOffset val:
                writer.WriteString(jsonElementName, val.UtcDateTime.ToString("yyyy-MM-ddTHH:mm:ssZ"));
                break;
            case BaseSpdxClass:
                writer.WriteString(jsonElementName, (string)(propVal as dynamic).SpdxId);
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
            case Uri:
                writer.WriteString(jsonElementName, propVal.ToString());
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
                writer.WriteStringValue((spdxClass as BaseSpdxClass)?.SpdxId);
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


    private static PropertyInfo? GetPropertyAttributeFromJsonElementName(Type typeToConvert, string elementName)
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

        return null;
    }
}