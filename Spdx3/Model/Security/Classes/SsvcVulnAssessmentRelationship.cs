using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Security.Classes;

/// <summary>
/// Provides an SSVC assessment for a vulnerability.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Security/Classes/SsvcVulnAssessmentRelationship
/// </summary>
public class SsvcVulnAssessmentRelationship : VulnAssessmentRelationship
{
    [JsonPropertyName("security_decisionType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required SsvcDecisionType? DecisionType { get; set; }

    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal SsvcVulnAssessmentRelationship()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public SsvcVulnAssessmentRelationship(Catalog catalog, CreationInfo creationInfo, Element from, List<Element> to,
        SsvcDecisionType decisionType) : base(catalog, creationInfo, RelationshipType.hasAssessmentFor, from, to)
    {
        DecisionType = decisionType;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(DecisionType));
    }
}