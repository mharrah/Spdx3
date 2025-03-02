using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Extension;

/// <summary>
///     A property name with an associated value.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Extension/Classes/CdxPropertyEntry/
/// </summary>
[method: SetsRequiredMembers]
public class CdxPropertyEntry(SpdxIdFactory spdxIdFactory, string cdxPropName) : BaseSpdxClass(spdxIdFactory)
{
    [SetsRequiredMembers]
    public CdxPropertyEntry(SpdxIdFactory spdxIdFactory, string cdxPropName, string cdxPropValue) : this(spdxIdFactory,
        cdxPropName)
    {
        CdxPropValue = cdxPropValue;
    }

    [JsonPropertyName("cdxPropName")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string CdxPropName { get; set; } = cdxPropName;

    [JsonPropertyName("cdxPropValue")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? CdxPropValue { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(CdxPropName));
    }
}