using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Security.Classes;

/// <summary>
/// Links a vulnerability and one or more elements designating the latter as products not affected by the vulnerability.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Security/Classes/VexNotAffectedVulnAssessmentRelationship/
/// </summary>
public class VexNotAffectedVulnAssessmentRelationship : VexVulnAssessmentRelationship
{
    [JsonPropertyName("security_impactStatement")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? ImpactStatement { get; set; }
    
    [JsonPropertyName("security_impactStatementTime")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public DateTimeOffset? ImpactStatementTime { get; set; }

    [JsonPropertyName("security_justificationType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public VexJustificationType? JustificationType { get; set; }
    
    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal VexNotAffectedVulnAssessmentRelationship()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public VexNotAffectedVulnAssessmentRelationship(Catalog catalog, CreationInfo creationInfo, Vulnerability from, List<Element> to) 
        : base(catalog, creationInfo, RelationshipType.doesNotAffect, from, to)
    {
    }


    public override void Validate()
    {
        base.Validate();
        /*
         Both impactStatement and justificationType properties have a cardinality of 0..1 making them optional.
         Nevertheless, to produce a valid VEX not_affected statement, one of them MUST be defined. 
         This is specified in the Minimum Elements for VEX.
         */
        if (ImpactStatement == null && JustificationType == null)
        {
            throw new Spdx3ValidationException("At least one of ImpactStatement and/or JustificationType must be specified.");
        }
    }
}