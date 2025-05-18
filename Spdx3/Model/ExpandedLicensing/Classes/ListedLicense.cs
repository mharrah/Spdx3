using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

/// <summary>
/// A license that is listed on the SPDX License List.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/ExpandedLicensing/Classes/ListedLicense/
///
/// The SPDX License List can be found here: https://spdx.org/licenses/
/// </summary>
public partial class ListedLicense : License
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
    protected internal ListedLicense()
    {
    }

    [SetsRequiredMembers]
    public ListedLicense(Catalog catalog, CreationInfo creationInfo, string licenseText) : base(catalog, creationInfo, licenseText)
    {
    }
}