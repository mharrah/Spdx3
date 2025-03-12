using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Extension.Classes;

/// <summary>
///     A property name with an associated value.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Extension/Classes/CdxPropertyEntry/
/// </summary>
public class CdxPropertyEntry : BaseModelClass
{
    [JsonPropertyName("cdxPropName")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string CdxPropName { get; set; }

    [JsonPropertyName("cdxPropValue")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? CdxPropValue { get; set; }

    // protected internal no-parm constructor required for deserialization
    protected internal CdxPropertyEntry()
    {
    }

    [SetsRequiredMembers]
    public CdxPropertyEntry(Catalog catalog, string cdxPropName, string cdxPropValue) : this(catalog,
        cdxPropName)
    {
        CdxPropValue = cdxPropValue;
    }

    [method: SetsRequiredMembers]
    public CdxPropertyEntry(Catalog catalog, string cdxPropName) : base(catalog)
    {
        CdxPropName = cdxPropName;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(CdxPropName));
    }
}