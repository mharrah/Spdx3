using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A verification method for software packages.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/PackageVerificationCode/
/// </summary>
public class PackageVerificationCode : IntegrityMethod
{
    [JsonPropertyName("algorithm")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public HashAlgorithm Algorithm { get; set; }

    [JsonPropertyName("hashValue")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string HashValue { get; set; }

    [JsonPropertyName("packageVerificationCodeExcludedFile")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<string> PackageVerificationCodeExcludedFile { get; } = new List<string>();

    // protected internal no-parm constructor required for deserialization
    protected internal PackageVerificationCode()
    {
    }

    [SetsRequiredMembers]
    public PackageVerificationCode(Catalog catalog, HashAlgorithm algorithm, string hashValue) :
        base(catalog)
    {
        Algorithm = algorithm;
        HashValue = hashValue;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Algorithm));
        ValidateRequiredProperty(nameof(HashValue));
    }
}