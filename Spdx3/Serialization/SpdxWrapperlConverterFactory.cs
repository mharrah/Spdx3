using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Spdx3.Serialization;

public class SpdxWrapperConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        var canConvert = typeToConvert.IsAssignableTo(typeof(PhysicalSerialization));

        return canConvert;
    }

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converterGenericType = typeof(SpdxWrapperConverter<>);

        Type[] typeArgs = [typeToConvert];
        var constructedType = converterGenericType.MakeGenericType(typeArgs);

        var converter = Activator.CreateInstance(constructedType,
            BindingFlags.Instance | BindingFlags.Public, null, null, null);

        return converter as JsonConverter;
    }
}