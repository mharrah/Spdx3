using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Utility;

namespace Spdx3.Model.Security.Classes;

/// <summary>
/// Designates elements as products where the impact of a vulnerability is being investigated.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Security/Classes/VexUnderInvestigationVulnAssessmentRelationship/
/// </summary>
public class VexUnderInvestigationVulnAssessmentRelationship : VexVulnAssessmentRelationship
{
    
    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal VexUnderInvestigationVulnAssessmentRelationship()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public VexUnderInvestigationVulnAssessmentRelationship(Catalog catalog, CreationInfo creationInfo, RelationshipType relationshipType, Vulnerability from, List<Element> to) : base(catalog, creationInfo, relationshipType, from, to)
    {
    }
}