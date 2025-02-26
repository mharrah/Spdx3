using System.Collections;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
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
            if (value == null) return;

            // If we're not writing a top level object, we only serialize the ID
            if (writer.CurrentDepth > 0)
            {
                writer.WriteStringValue((value as dynamic).SpdxId);
                return;
            }
            
            // Otherwise, we need to serialize all the properties
            var props = value.GetType().GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(JsonPropertyNameAttribute)));
            
            writer.WriteStartObject();
            
            foreach (var prop in props.Where(prop => prop.GetValue(value) != null))
            {
                var propVal = prop.GetValue(value);
                if (prop.PropertyType.Name.Contains("IList"))
                {
                    var breakpoint = 0;
                }
                
                // If it's a list of OTHER SpdxClasses, don't serialize the objects, just serialize an array of references
                if (prop.PropertyType.IsGenericType && 
                    prop.PropertyType.GenericTypeArguments[0].IsSubclassOf(typeof(BaseSpdxClass)) && 
                    typeof(System.Collections.IList).IsAssignableFrom(propVal.GetType())
                    )
                {
                    var list = (IList)propVal;
                    
                    if (list.Count == 0)
                    {
                        continue;
                    }
                    writer.WritePropertyName(prop.Name);
                    writer.WriteStartArray();
                    foreach (object spdxClass in list) 
                    {
                        writer.WriteStringValue((spdxClass as BaseSpdxClass).SpdxId);
                    }
                    writer.WriteEndArray();
                    continue;
                }
                
                switch (propVal)
                {
                    case Enum:
                        writer.WriteString(prop.Name, Enum.GetName(propVal.GetType(), propVal));
                        break;
                    case int val:
                        writer.WriteNumber(prop.Name, val);
                        break;
                    case string val:
                        writer.WriteString(prop.Name, val);
                        break;
                    case BaseSpdxClass:
                        writer.WriteString(prop.Name, (string)(propVal as dynamic).SpdxId);
                        break;
                    case List<string> list:
                        writer.WriteStartArray();
                        list.ForEach(str => writer.WriteStringValue(str));
                        writer.WriteEndArray();
                        break;
                    case List<Enum> list:
                        writer.WriteStartArray();
                        list.ForEach(str => writer.WriteStringValue(Enum.GetName(propVal.GetType(), propVal)));
                        writer.WriteEndArray();
                        break;
                    case List<object> list:
                        writer.WriteStartArray();
                        list.ForEach(spdxClass => writer.WriteStringValue((propVal as dynamic).SpdxId));
                        writer.WriteEndArray();
                        break;
                    default:
                        writer.WriteString(prop.GetType().Name, propVal.ToString());
                        break;
                }
            }
            
            
            writer.WriteEndObject();
        }
    }
}