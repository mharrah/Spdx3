using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
/// A mathematically calculated representation of a grouping of data.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Hash/
/// </summary>
public class Hash : IntegrityMethod
{
    [JsonPropertyName("algorithm")]
    public HashAlgorithm? Algorithm { get; set; }
    
    [JsonPropertyName("hashValue")]
    public string? HashValue { get; set; }

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Algorithm));
        ValidateRequiredProperty(nameof(HashValue));
    }
}