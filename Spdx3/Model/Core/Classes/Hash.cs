using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A mathematically calculated representation of a grouping of data.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Hash/
/// </summary>
public class Hash : IntegrityMethod
{
    [SetsRequiredMembers]
    public Hash(SpdxIdFactory spdxIdFactory, HashAlgorithm algorithm, string hashValue) : base(spdxIdFactory)
    {
        Algorithm = algorithm;
        HashValue = hashValue;
    }

    [JsonPropertyName("algorithm")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required HashAlgorithm Algorithm { get; set; }

    [JsonPropertyName("hashValue")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string HashValue { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Algorithm));
        ValidateRequiredProperty(nameof(HashValue));
    }
}