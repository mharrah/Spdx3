using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.SimpleLicensing.Classes;

/// <summary>
/// An SPDX Element containing an SPDX license expression string.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/SimpleLicensing/Classes/LicenseExpression/
/// </summary>
public class LicenseExpression : AnyLicenseInfo
{
    [JsonPropertyName("licenseExpression")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string LicenseExpressionText { get; set; }
    
    [JsonPropertyName("customIdToUri")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public DictionaryEntry? CustomIdToUri { get; set; }
    
    [JsonPropertyName("licenseListVersion")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? LicenseListVersion { get; set; }
 
    // protected internal no-parm constructor required for deserialization
    protected internal LicenseExpression()
    {
    }
    
    [SetsRequiredMembers]
    public LicenseExpression(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo, string licenseExpression) : base(spdxIdFactory, creationInfo)
    {
        LicenseExpressionText = licenseExpression;
    }
}