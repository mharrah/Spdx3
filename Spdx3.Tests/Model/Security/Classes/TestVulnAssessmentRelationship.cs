using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Security.Classes;

/// <summary>
/// Abstract implementation of VulnAssessmentRelationship for testing
/// </summary>
public class TestVulnAssessmentRelationship : VulnAssessmentRelationship
{
        
    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal TestVulnAssessmentRelationship()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public TestVulnAssessmentRelationship(Catalog catalog, CreationInfo creationInfo,
        RelationshipType relationshipType, Element from, List<Element> to) : base(catalog, creationInfo, relationshipType, from, to)
    {
    }    

}