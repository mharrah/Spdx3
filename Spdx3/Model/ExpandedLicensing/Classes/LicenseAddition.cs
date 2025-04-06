using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

/// <summary>
/// Abstract class for additional text intended to be added to a License, but which is not itself a standalone License.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/ExpandedLicensing/Classes/LicenseAddition/
/// </summary>
public abstract class LicenseAddition : Element
{
    [JsonPropertyName("expandedlicensing_additionText")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string AdditionText { get; set; }

    [JsonPropertyName("expandedlicensing_isDeprecatedAdditionId")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public bool? IsDeprecatedAdditionId { get; set; }

    [JsonPropertyName("expandedlicensing_licenseXml")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? LicenseXml { get; set; }

    [JsonPropertyName("expandedlicensing_obsoletedBy")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? ObsoletedBy { get; set; }

    [JsonPropertyName("expandedlicensing_seeAlso")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<Uri> SeeAlso { get; set; } = new List<Uri>();

    [JsonPropertyName("expandedlicensing_standardAdditionTemplate")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? StandardAdditionTemplate { get; set; }

    protected internal LicenseAddition()
    {
    }

    [SetsRequiredMembers]
    public LicenseAddition(Catalog catalog, CreationInfo creationInfo, string additionText) : base(catalog,
        creationInfo)
    {
        AdditionText = additionText;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(AdditionText));
    }
}