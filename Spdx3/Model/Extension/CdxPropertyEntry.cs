using System.Text.Json.Serialization;
using Spdx3.Serialization;

namespace Spdx3.Model.Extension;

/// <summary>
/// A property name with an associated value.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Extension/Classes/CdxPropertyEntry/
/// </summary>
public class CdxPropertyEntry : BaseSpdxClass
{
    [JsonPropertyName("cdxPropName")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? CdxPropName { get; set; }

    [JsonPropertyName("cdxPropValue")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? CdxPropValue { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(CdxPropName));
    }

    internal CdxPropertyEntry()
    {
    }
}