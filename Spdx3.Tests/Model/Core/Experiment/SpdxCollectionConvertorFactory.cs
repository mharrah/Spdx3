using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Spdx3.Model;
using Xunit.Sdk;

namespace Spdx3.Tests.Model.Core.Experiment;

public class SpdxCollectionConvertorFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        if (!typeToConvert.IsGenericType)
        {
            return false;
        }

        if (typeToConvert.GetGenericTypeDefinition() != typeof(IList<>))
        {
            return false;
        }
        
        var listType = typeToConvert.GetGenericArguments()[0];

        var canConvert = (listType.Implements(typeof(ISpdxClass)));
        
        return canConvert;
    }

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converterGenericType = typeof(SpdxCollectionConvertor<>);

        Type[] typeArgs = { typeToConvert };
        Type constructedType = converterGenericType.MakeGenericType(typeArgs);
        
        var converter  = Activator.CreateInstance(constructedType, BindingFlags.Instance | BindingFlags.Public, null, null, null);
        
        return converter as JsonConverter;
    }

    private class SpdxCollectionConvertor<T> : JsonConverter<T>
    {
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            if (value == null) return;

            // If the list is empty, don't write anything
            if ((value as dynamic).Count == 0) return;
            
            writer.WriteStartArray();
            foreach (var item in (value as dynamic))
            {
                writer.WriteStringValue(item.SpdxId);
            }
            writer.WriteEndArray();
        }
    }
}