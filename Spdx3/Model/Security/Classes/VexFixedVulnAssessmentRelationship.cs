using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Utility;

namespace Spdx3.Model.Security.Classes;

/// <summary>
/// Links a vulnerability and elements representing products (in the VEX sense) where a fix has been applied and are no longer affected.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Security/Classes/VexFixedVulnAssessmentRelationship/
/// </summary>
public class VexFixedVulnAssessmentRelationship : VexVulnAssessmentRelationship
{
    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal VexFixedVulnAssessmentRelationship()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public VexFixedVulnAssessmentRelationship(Catalog catalog, CreationInfo creationInfo, Vulnerability from,
        List<Element> to) : base(catalog, creationInfo, RelationshipType.fixedIn, from, to)
    {
    }
}