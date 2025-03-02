using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A verification method for software packages.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/PackageVerificationCode/
/// </summary>
public class PackageVerificationCode : IntegrityMethod
{
    [SetsRequiredMembers]
    public PackageVerificationCode(SpdxIdFactory spdxIdFactory, HashAlgorithm algorithm, string hashValue) :
        base(spdxIdFactory)
    {
        Algorithm = algorithm;
        HashValue = hashValue;
    }

    [JsonPropertyName("algorithm")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public HashAlgorithm Algorithm { get; set; }

    [JsonPropertyName("hashValue")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string HashValue { get; set; }

    [JsonPropertyName("packageVerificationCodeExcludedFile")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<string> PackageVerificationCodeExcludedFile { get; } = new List<string>();

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Algorithm));
        ValidateRequiredProperty(nameof(HashValue));
    }
}