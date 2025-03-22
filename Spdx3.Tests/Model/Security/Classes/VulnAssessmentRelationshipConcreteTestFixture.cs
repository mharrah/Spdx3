using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Security.Classes;

/// <summary>
/// Abstract implementation of VulnAssessmentRelationship for testing
/// </summary>
public class VulnAssessmentRelationshipConcreteTestFixture : VulnAssessmentRelationship
{
        
    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal VulnAssessmentRelationshipConcreteTestFixture()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public VulnAssessmentRelationshipConcreteTestFixture(Catalog catalog, CreationInfo creationInfo,
        RelationshipType relationshipType, Element from, List<Element> to) : base(catalog, creationInfo, relationshipType, from, to)
    {
    }    

}