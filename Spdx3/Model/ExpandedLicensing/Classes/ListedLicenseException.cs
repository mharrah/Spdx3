using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

/// <summary>
/// A license exception that is listed on the SPDX Exceptions list.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/ExpandedLicensing/Classes/ListedLicenseException/
///
/// Note that despite the name, this is not a C# Exception class.
/// </summary>
public class ListedLicenseException : LicenseAddition
{
    [JsonPropertyName("expandedlicensing_deprecatedVersion")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? DeprecatedVersion { get; set; }
    
    [JsonPropertyName("expandedlicensing_listVersionAdded")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? ListVersionAdded { get; set; }

    /// <summary>
    /// No-arg constructor required for serialization/deserialization
    /// </summary>
    protected internal ListedLicenseException()
    {
    }

    [SetsRequiredMembers]
    public ListedLicenseException(Catalog catalog, CreationInfo creationInfo, string additionText) : base(catalog, creationInfo, additionText)
    {
    }
}