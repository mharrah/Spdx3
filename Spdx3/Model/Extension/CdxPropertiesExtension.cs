using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Extension;

public class CdxPropertiesExtension : Extension
{

    [JsonPropertyName("cdxProperty")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<CdxPropertyEntry> CdxProperty { get; init; }

    [SetsRequiredMembers]
    public CdxPropertiesExtension(SpdxIdFactory spdxIdFactory, IList<CdxPropertyEntry> cdxProperties) : base(
        spdxIdFactory)
    {
        if (cdxProperties.Count == 0)
        {
            throw new Spdx3ValidationException(this, nameof(CdxProperty), "Collection cannot be empty.");
        }

        CdxProperty = cdxProperties;
    }

    public override void Validate()
    {
        base.Validate();
        if (CdxProperty.Count == 0)
        {
            throw new Spdx3ValidationException(this, nameof(CdxProperty), "Collection cannot be empty.");
        }
    }
}