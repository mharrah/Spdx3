using System.Text.Json.Serialization;

namespace Spdx3.Model.Extension;

/// <summary>
/// A property name with an associated value.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Extension/Classes/CdxPropertyEntry/
/// </summary>
public class CdxPropertyEntry : BaseSpdxClass
{
    [JsonPropertyName("cdxPropName")]
    public string? CdxPropName { get; set; }

    [JsonPropertyName("cdxPropValue")]
    public string? CdxPropValue { get; set; }

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(CdxPropName));
    }
    
    internal CdxPropertyEntry()
    {
    }
}