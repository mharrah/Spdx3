using System.Collections;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Spdx3.Serialization;

internal class SpdxWrapperConverter<T> : JsonConverter<T>
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        /*
        var result = (T?)Activator.CreateInstance(typeToConvert, true);
        if (result == null)
        {
            throw new Spdx3SerializationException("Could not create instance of type " + typeof(T));
        }
        PropertyInfo? currentProp = null;
        while (reader.Read())
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    throw new Spdx3SerializationException($"There should not be nested objects in {currentProp?.Name}");
                case JsonTokenType.EndObject:
                    break;
                case JsonTokenType.StartArray:
                    break;
                case JsonTokenType.EndArray:
                    break;
                case JsonTokenType.String:
                    var strVal = reader.GetString();
                    if (currentProp == null)
                    {
                        throw new Spdx3SerializationException($"String value '{strVal}' encountered outside of a property");
                    }
                    if (strVal == null)
                    {
                        throw new Spdx3SerializationException("Null value encountered for string value");
                    }
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
                        var genericType = currentProp.PropertyType.GetGenericArguments()[0];
                        if (genericType == typeof(string))
                        {
                            if (currentProp.GetValue(result) is not IList listVal)
                            {
                                throw new Spdx3SerializationException($"List property {currentProp.Name} was not initialized as a list");
                            }
                            listVal.Add(strVal);
                        }
                        else if (genericType.IsAssignableTo(typeof(BaseModelClass)))
                        {
                            var placeHolder = Convert.ChangeType(Activator.CreateInstance(genericType, true), genericType);
                            if (placeHolder == null)
                            {
                                throw new Spdx3Exception($"Could not create instance of type {genericType}");
                            }

                            var type = placeHolder.GetType();
                            if (type == null)
                            {
                                throw new Spdx3Exception($"Could not determine type of object {nameof(placeHolder)}");
                            }

                            var spdxIdProperty = type.GetProperty("SpdxId");
                            if (spdxIdProperty == null)
                            {
                                throw new Spdx3SerializationException($"Unable to get property 'SpdxId' of type {type}");
                            }
                            spdxIdProperty.SetValue(placeHolder, strVal);

                            var typeProperty = type.GetProperty("Type");
                            if (typeProperty == null)
                            {
                                throw new Spdx3SerializationException($"Unable to get property 'Type' of type {type}");
                            }

                            typeProperty.SetValue(placeHolder, Naming.SpdxTypeForClass(genericType));
                            if (currentProp.GetValue(result) is not IList listVal)
                            {
                                throw new Spdx3SerializationException($"List property {currentProp.Name} was not initialized as a list");
                            }
                            listVal.Add(placeHolder);
                        }
                        else
                        {
                            throw new Spdx3SerializationException($"The type {genericType} is not supported");
                        }
                    }
                    else if (currentProp.PropertyType.IsEnum)
                    {
                        currentProp.SetValue(result, Enum.Parse(currentProp.PropertyType, strVal));
                    }
                    else if (currentProp.PropertyType.IsSubclassOf(typeof(BaseModelClass)))
                    {
                        var placeHolder = Convert.ChangeType(Activator.CreateInstance(currentProp.PropertyType, true), currentProp.PropertyType);
                        if (placeHolder == null)
                        {
                            throw new Spdx3SerializationException($"Unable to create instance of type {currentProp.PropertyType}");
                        }
                        currentProp.PropertyType.GetProperty("SpdxId").SetValue(placeHolder, strVal);
                        currentProp.PropertyType.GetProperty("Type").SetValue(placeHolder, Naming.SpdxTypeForClass(currentProp.PropertyType));
                        currentProp.SetValue(result, placeHolder);
                    }
                    else
                    {
                        throw new NotImplementedException($"No handler for string for a {currentProp.PropertyType.Name}");
                    }

                    break;
                case JsonTokenType.Number:
                    var intVal = reader.GetInt32();
                    if (currentProp == null)
                    {
                        throw new Spdx3SerializationException($"No current property to hold int value {intVal}");
                    }

                    currentProp.SetValue(result, intVal);

                    break;
                case JsonTokenType.PropertyName:
                    var currentPropName = reader.GetString();
                    if (currentPropName == null)
                    {
                        throw new Spdx3Exception("Expected a property name but got null value");
                    }
                    currentProp = GetPropertyAttributeFromJsonElementName(typeToConvert, currentPropName);
                    if (currentProp == null)
                    {
                        throw new Spdx3SerializationException(
                            $"Property {currentPropName} is not found on type {typeToConvert}");
                    }

                    break;
            }

        return result;
        */
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            return;
        }

        var props = value.GetType().GetProperties();

        writer.WriteStartObject();

        foreach (var prop in props.Where(prop => prop.GetValue(value) != null))
        {
            var jsonElementName = GetJsonElementNameFromPropertyAttribute(prop);

            var propType = prop.PropertyType;
            var propVal = prop.GetValue(value);

            // If it's a list of OTHER SpdxClasses, don't serialize the objects, just serialize an array of references
            if (propVal is IList spdxClasses)
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

            if (propVal is string)
            {
                writer.WriteString(jsonElementName, propVal.ToString());
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