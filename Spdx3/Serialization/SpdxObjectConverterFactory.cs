using System.Collections;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model;

namespace Spdx3.Serialization;

public class SpdxObjectConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        var canConvert = typeToConvert.IsSubclassOf(typeof(BaseSpdxClass));

        return canConvert;
    }

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converterGenericType = typeof(SpdxObjectConvertor<>);

        Type[] typeArgs = [typeToConvert];
        var constructedType = converterGenericType.MakeGenericType(typeArgs);

        var converter = Activator.CreateInstance(constructedType,
            BindingFlags.Instance | BindingFlags.Public, null, null, null);

        return converter as JsonConverter;
    }

    private class SpdxObjectConvertor<T> : JsonConverter<T>
    {
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
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
                var propVal = prop.GetValue(value);
                var propType = prop.PropertyType;

                var jsonElementName = GetJsonElementNameFromPropertyAttribute(prop);


                // If it's a list of OTHER SpdxClasses, don't serialize the objects, just serialize an array of references
                if (propType.IsGenericType &&
                    propType.GenericTypeArguments[0].IsSubclassOf(typeof(BaseSpdxClass)) &&
                    propVal is IList spdxClasses
                   )
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
                    propVal is IList enums
                   )
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
                        list.ForEach(str => writer.WriteStringValue(str));
                        writer.WriteEndArray();
                    }
                    break;
                case List<Enum> list:
                    if (list.Count > 0)
                    {
                        writer.WritePropertyName(jsonElementName);
                        writer.WriteStartArray();
                        list.ForEach(str => writer.WriteStringValue(Enum.GetName(propVal.GetType(), propVal)));
                        writer.WriteEndArray();
                    }
                    break;
                case List<object> list:
                    if (list.Count > 0)
                    {
                        writer.WritePropertyName(jsonElementName);
                        writer.WriteStartArray();
                        list.ForEach(spdxClass => writer.WriteStringValue((propVal as dynamic).SpdxId));
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
    }
}