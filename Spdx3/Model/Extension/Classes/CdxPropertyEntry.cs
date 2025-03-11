using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Extension.Classes;

/// <summary>
///     A property name with an associated value.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Extension/Classes/CdxPropertyEntry/
/// </summary>
public class CdxPropertyEntry : BaseSpdxClass
{
    // protected internal no-parm constructor required for deserialization
    protected internal CdxPropertyEntry()
    {
    }

    [SetsRequiredMembers]
    public CdxPropertyEntry(SpdxCatalog spdxCatalog, string cdxPropName, string cdxPropValue) : this(spdxCatalog,
        cdxPropName)
    {
        CdxPropValue = cdxPropValue;
    }

    [method: SetsRequiredMembers]
    public CdxPropertyEntry(SpdxCatalog spdxCatalog, string cdxPropName) : base(spdxCatalog)
    {
        CdxPropName = cdxPropName;
    }

    [JsonPropertyName("cdxPropName")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string CdxPropName { get; set; }

    [JsonPropertyName("cdxPropValue")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? CdxPropValue { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(CdxPropName));
    }
}