using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Extension;

/// <summary>
///     A property name with an associated value.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Extension/Classes/CdxPropertyEntry/
/// </summary>
public class CdxPropertyEntry : BaseSpdxClass
{
    [SetsRequiredMembers]
    public CdxPropertyEntry(SpdxIdFactory spdxIdFactory, string cdxPropName, string cdxPropValue) : this(spdxIdFactory,
        cdxPropName)
    {
        CdxPropValue = cdxPropValue;
    }

    [SetsRequiredMembers]
    public CdxPropertyEntry(SpdxIdFactory spdxIdFactory, string cdxPropName) : base(spdxIdFactory)
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