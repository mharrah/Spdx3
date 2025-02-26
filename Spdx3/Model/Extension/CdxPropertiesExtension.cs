using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Serialization;

namespace Spdx3.Model.Extension;

public class CdxPropertiesExtension : Extension
{
    [JsonPropertyName("cdxProperty")]
    [JsonConverter(typeof(SpdxCollectionConverterFactory))]
    public IList<CdxPropertyEntry> CdxProperties { get; set; } = new List<CdxPropertyEntry>();

    public new void Validate()
    {
        base.Validate();
        if (CdxProperties.Count == 0)
        {
            throw new Spdx3ValidationException(this, nameof(CdxProperties), "Collection cannot be empty.");
        }
    }
    
    internal CdxPropertiesExtension()
    {
    }
}