using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Security.Classes;

/// <summary>
/// Abstract implementation of VexVulnAssessmentRelationship for testing
/// </summary>
public class VexVulnAssessmentRelationshipConcreteTestFixture : VexVulnAssessmentRelationship
{
    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal VexVulnAssessmentRelationshipConcreteTestFixture()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public VexVulnAssessmentRelationshipConcreteTestFixture(Catalog catalog, CreationInfo creationInfo,
        RelationshipType relationshipType, Vulnerability from, List<Element> to) : base(catalog, creationInfo, relationshipType, from, to)
    {
    }    
}