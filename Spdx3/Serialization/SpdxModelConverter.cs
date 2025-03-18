using System.Collections;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model;
using Spdx3.Utility;

namespace Spdx3.Serialization;

public class SpdxModelConverter<T> : JsonConverter<T>
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = (T?)Activator.CreateInstance(typeToConvert, true) ??
                     throw new Spdx3SerializationException($"Could not create instance of {typeToConvert}");

        PropertyInfo? currentProp = null;
        while (reader.Read())
            switch (reader.TokenType)
            {
                case JsonTokenType.PropertyName:
                    var currentPropName = reader.GetString() ??
                                          throw new Spdx3SerializationException("Couldn't read property name");
                    currentProp = GetPropertyFromJsonElementName(typeToConvert, currentPropName);
                    break;

                case JsonTokenType.StartObject:
                    throw new Spdx3SerializationException($"There should not be nested objects in {currentProp?.Name}");

                case JsonTokenType.String:
                    var strVal = reader.GetString() ?? throw new Spdx3SerializationException("Couldn't read string");
                    var currentPropertyType = currentProp?.PropertyType ??
                                              throw new Spdx3SerializationException(
                                                  "Couldn't get current property type");
                    
                    if (currentPropertyType == typeof(string))
                    {
                        currentProp.SetValue(result, strVal);
                    }
                    else if (currentPropertyType == typeof(DateTimeOffset))
                    {
                        currentProp.SetValue(result, DateTimeOffset.Parse(strVal));
                    }
                    else if (currentPropertyType.IsGenericType)
                    {
                        var genericType = currentPropertyType.GetGenericArguments()[0];
                        if (genericType == typeof(string))
                        {
                            if (currentProp.GetValue(result) is not IList listVal)
                            {
                                throw new Spdx3SerializationException(
                                    $"List property {currentProp.Name} was not initialized as a list");
                            }

                            listVal.Add(strVal);
                        }
                        else if (genericType.IsAssignableTo(typeof(BaseModelClass)))
                        {
                            /*
                             * At this point we have a string that is the URN of another Element, which we may or may not
                             * have read yet.  For now, make a placeholder element of the type needed and the ID in the json.
                             * Later, we're going to need to go through the objects and replace the placeholder with the real one.
                             */
                            var placeHolder =
                                Convert.ChangeType(Activator.CreateInstance(genericType, true), genericType) ??
                                throw new Spdx3SerializationException($"Could not create instance of {genericType}");
                            var type = placeHolder.GetType();
                            var spdxIdProperty = type.GetProperty("SpdxId") ??
                                                 throw new Spdx3SerializationException("Could not get spdxId property");
                            spdxIdProperty.SetValue(placeHolder, strVal);

                            var typeProperty = type.GetProperty("Type") ??
                                               throw new Spdx3SerializationException("Could not get type property");
                            typeProperty.SetValue(placeHolder, Naming.SpdxTypeForClass(genericType));
                            if (currentProp.GetValue(result) is not IList listVal)
                            {
                                throw new Spdx3SerializationException(
                                    $"List property {currentProp.Name} was not initialized as a list");
                            }

                            listVal.Add(placeHolder);
                        }
                        else
                        {
                            throw new Spdx3SerializationException($"The type {genericType} is not supported");
                        }
                    }
                    else if (currentPropertyType.IsEnum)
                    {
                        currentProp.SetValue(result, Enum.Parse(currentPropertyType, strVal));
                    }
                    else if (currentPropertyType.IsSubclassOf(typeof(BaseModelClass)))
                    {
                        /*
                         * At this point we have a string that is the URN of another Element, which we may or may not
                         * have read yet.  For now, make a placeholder element of the type needed and the ID in the json.
                         * Later, we're going to need to go through the objects and replace the placeholder with the real one.
                         */
                        var placeHolder = Convert.ChangeType(Activator.CreateInstance(currentPropertyType, true),
                            currentPropertyType);
                        currentPropertyType.GetProperty("SpdxId")?.SetValue(placeHolder, strVal);
                        currentPropertyType.GetProperty("Type")?.SetValue(placeHolder,
                            Naming.SpdxTypeForClass(currentPropertyType));
                        currentProp.SetValue(result, placeHolder);
                    }
                    else
                    {
                        throw new NotImplementedException(
                            $"No handler for string for a {currentPropertyType.Name}");
                    }

                    break;
                case JsonTokenType.Number:
                    var intVal = reader.GetInt32();
                    (currentProp ?? throw new Spdx3SerializationException("No current property")).SetValue(result,
                        intVal);

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
            case string val:
                writer.WriteString(jsonElementName, val);
                break;
            case DateTimeOffset val:
                writer.WriteString(jsonElementName, val.UtcDateTime.ToString("yyyy-MM-ddTHH:mm:ssZ"));
                break;
            case BaseModelClass:
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
                writer.WriteStringValue((spdxClass as BaseModelClass)?.SpdxId);
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


    private static PropertyInfo? GetPropertyFromJsonElementName(Type typeToConvert, string elementName)
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