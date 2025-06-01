using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Spdx3.Model;

namespace Spdx3.Serialization;

public class SpdxModelConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        var canConvert = typeToConvert.IsSubclassOf(typeof(BaseModelClass));

        return canConvert;
    }

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converterGenericType = typeof(SpdxModelConverter<>);

        Type[] typeArgs = [typeToConvert];
        var constructedType = converterGenericType.MakeGenericType(typeArgs);

        var converter = Activator.CreateInstance(constructedType, BindingFlags.Instance | BindingFlags.Public, null,
            null, null);

        return converter as JsonConverter;
    }
}