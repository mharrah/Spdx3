using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Extension.Classes;

public class CdxPropertiesExtension : Extension
{
    // protected internal no-parm constructor required for deserialization
    protected internal CdxPropertiesExtension()
    {
    }
    
    [SetsRequiredMembers]
    public CdxPropertiesExtension(SpdxCatalog spdxCatalog, IList<CdxPropertyEntry> cdxProperties) : base(
        spdxCatalog)
    {
        if (cdxProperties.Count == 0)
        {
            throw new Spdx3ValidationException(this, nameof(CdxProperty), "Collection cannot be empty.");
        }

        CdxProperty = cdxProperties;
    }

    [JsonPropertyName("cdxProperty")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<CdxPropertyEntry> CdxProperty { get; init; } = new List<CdxPropertyEntry>();

    public override void Validate()
    {
        base.Validate();
        if (CdxProperty.Count == 0)
        {
            throw new Spdx3ValidationException(this, nameof(CdxProperty), "Collection cannot be empty.");
        }
    }
}