using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A verification method for software packages.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/PackageVerificationCode/
/// </summary>
public class PackageVerificationCode : IntegrityMethod
{
    [JsonPropertyName("algorithm")]
    public HashAlgorithm? Algorithm { get; set; }

    [JsonPropertyName("hashValue")]
    public string? HashValue { get; set; }

    [JsonPropertyName("packageVerificationCodeExcludedFile")]
    public IList<string> PackageVerificationCodeExcludedFile { get; set; } = new List<string>();

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Algorithm));
        ValidateRequiredProperty(nameof(HashValue));
    }
}