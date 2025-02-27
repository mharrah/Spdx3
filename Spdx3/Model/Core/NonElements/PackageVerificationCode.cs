using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A verification method for software packages.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/PackageVerificationCode/
/// </summary>
public class PackageVerificationCode : IntegrityMethod
{
    [JsonPropertyName("algorithm")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public HashAlgorithm? Algorithm { get; set; }

    [JsonPropertyName("hashValue")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? HashValue { get; set; }

    [JsonPropertyName("packageVerificationCodeExcludedFile")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<string> PackageVerificationCodeExcludedFile { get; } = new List<string>();

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Algorithm));
        ValidateRequiredProperty(nameof(HashValue));
    }

    internal PackageVerificationCode()
    {
    }
}