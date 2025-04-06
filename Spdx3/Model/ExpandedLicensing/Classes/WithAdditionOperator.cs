using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

/// <summary>
/// Portion of an AnyLicenseInfo representing a License which has additional text applied to it.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/ExpandedLicensing/Classes/WithAdditionOperator/
/// </summary>
public class WithAdditionOperator : AnyLicenseInfo
{
    [JsonPropertyName("expandedlicensing_subjectAddition")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required LicenseAddition SubjectAddition { get; set; }
    
    [JsonPropertyName("expandedlicensing_subjectExtendableLicense")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required ExtendableLicense SubjectExtendableLicense { get; set; }

    protected internal WithAdditionOperator()
    {
    }

    [SetsRequiredMembers]
    public WithAdditionOperator(Catalog catalog, CreationInfo creationInfo, 
        ExtendableLicense subjectExtendableLicense, LicenseAddition subjectAddition) : base(catalog, creationInfo)
    {
        SubjectAddition = subjectAddition;
        SubjectExtendableLicense = subjectExtendableLicense;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(SubjectAddition));
        ValidateRequiredProperty(nameof(SubjectExtendableLicense));
    }
}