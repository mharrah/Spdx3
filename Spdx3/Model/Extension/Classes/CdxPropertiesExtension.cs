using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Extension.Classes;

public class CdxPropertiesExtension : Extension
{
    [JsonPropertyName("extension_cdxProperty")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<CdxPropertyEntry> CdxProperty { get; init; } = new List<CdxPropertyEntry>();

    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal CdxPropertiesExtension()
    {
    }

    [SetsRequiredMembers]
    public CdxPropertiesExtension(Catalog catalog, IList<CdxPropertyEntry> cdxProperties) : base(
        catalog)
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