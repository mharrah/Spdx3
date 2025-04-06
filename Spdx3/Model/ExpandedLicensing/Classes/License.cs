using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

/// <summary>
/// Abstract class for the portion of an AnyLicenseInfo representing a license.
/// </summary>
public abstract class License : ExtendableLicense
{
    [JsonPropertyName("simplelicensing_licenseText")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string LicenseText { get; set; }
    
    [JsonPropertyName("expandedlicensing_isDeprecatedLicenseId")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public bool? IsDeprecatedLicenseId { get; set; }

    [JsonPropertyName("expandedlicensing_isFsfLibre")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public bool? IsFsfLibre { get; set; }
    
    [JsonPropertyName("expandedlicensing_isOsiApproved")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public bool? IsOsiApproved { get; set; }

    [JsonPropertyName("expandedlicensing_licenseXml")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? LicenseXml { get; set; }
    
    [JsonPropertyName("expandedlicensing_obsoletedBy")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? ObsoletedBy { get; set; }
    
    [JsonPropertyName("expandedlicensing_seeAlso")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<Uri> SeeAlso { get; set; } = new List<Uri>();
    
    [JsonPropertyName("expandedlicensing_standardLicenseHeader")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? StandardLicenseHeader { get; set; }
    
    [JsonPropertyName("expandedlicensing_standardLicenseTemplate")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? StandardLicenseTemplate { get; set; }
    
    /// <summary>
    /// No-arg constructor required for serialization/deserialization
    /// </summary>
    protected internal License()
    {
    }

    [SetsRequiredMembers]
    protected License(Catalog catalog, CreationInfo creationInfo, string licenseText) : base(catalog, creationInfo)
    {
        this.LicenseText = licenseText;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(LicenseText));
    }
}