using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

/// <summary>
/// Portion of an AnyLicenseInfo representing this version, or any later version, of the indicated License.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/ExpandedLicensing/Classes/OrLaterOperator/
/// </summary>
public class OrLaterOperator : ExtendableLicense
{
    [JsonPropertyName("expandedlicensing_subjectLicense")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required License SubjectLicense { get; set; }

    protected internal OrLaterOperator()
    {
    }

    [SetsRequiredMembers]
    public OrLaterOperator(Catalog catalog, CreationInfo creationInfo, License subjectLicense) : base(catalog, creationInfo)
    {
        this.SubjectLicense = subjectLicense;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(SubjectLicense));
    }
}