using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Lite;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.SimpleLicensing.Classes;

/// <summary>
///     An SPDX Element containing an SPDX license expression string.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/SimpleLicensing/Classes/LicenseExpression/
/// </summary>
public class LicenseExpression : AnyLicenseInfo, ILiteDomainCompliantElement
{
    [JsonPropertyName("simplelicensing_licenseExpression")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string LicenseExpressionText { get; set; }

    [JsonPropertyName("simplelicensing_customIdToUri")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public DictionaryEntry? CustomIdToUri { get; set; }

    [JsonPropertyName("simplelicensing_licenseListVersion")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? LicenseListVersion { get; set; }

    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal LicenseExpression()
    {
    }

    [SetsRequiredMembers]
    public LicenseExpression(Catalog catalog, CreationInfo creationInfo, string licenseExpression) : base(catalog,
        creationInfo)
    {
        LicenseExpressionText = licenseExpression;
    }

    public void Accept(ILiteDomainComplianceVisitor visitor)
    {
        visitor.Visit(this);
    }
}