using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Serialization;

namespace Spdx3.Model.Extension;

public class CdxPropertiesExtension : Extension
{
    [JsonPropertyName("cdxProperty")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<CdxPropertyEntry> CdxProperty { get; set; } = new List<CdxPropertyEntry>();

    public override void Validate()
    {
        base.Validate();
        if (CdxProperty.Count == 0)
        {
            throw new Spdx3ValidationException(this, nameof(CdxProperty), "Collection cannot be empty.");
        }
    }


    internal CdxPropertiesExtension()
    {
    }
}