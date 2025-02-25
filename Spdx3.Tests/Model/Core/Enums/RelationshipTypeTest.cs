using System.Text.Json;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Enums;

public class RelationshipTypeTest
{
    [Fact]
    public void RelationshipType_HasCorrect_Count()
    {
        Assert.Equal(59, Enum.GetValues(typeof(RelationshipType)).Length);
    }

    [Fact]
    public void RelationshipType_Single_SerializesAsString()
    {
        // Arrange
        const RelationshipType enumVal = RelationshipType.hasPrerequisite;

        // Act
        var json = JsonSerializer.Serialize<object>(Convert.ChangeType(enumVal, typeof(object)));

        // Assert
        Assert.Equal("\"hasPrerequisite\"", json);
    }

    [Fact]
    public void RelationshipType_Array_SerializesAsStrings()
    {
        // Arrange
        var enumArray = new[]
        {
            RelationshipType.affects,
            RelationshipType.amendedBy,
            RelationshipType.ancestorOf,
            RelationshipType.availableFrom,
            RelationshipType.configures,
            RelationshipType.contains,
            RelationshipType.coordinatedBy,
            RelationshipType.copiedTo,
            RelationshipType.delegatedTo,
            RelationshipType.dependsOn,
            RelationshipType.descendantOf,
            RelationshipType.describes,
            RelationshipType.doesNotAffect,
            RelationshipType.expandsTo,
            RelationshipType.exploitCreatedBy,
            RelationshipType.fixedBy,
            RelationshipType.fixedIn,
            RelationshipType.foundBy,
            RelationshipType.generates,
            RelationshipType.hasAddedFile,
            RelationshipType.hasAssessmentFor,
            RelationshipType.hasAssociatedVulnerability,
            RelationshipType.hasConcludedLicense,
            RelationshipType.hasDataFile,
            RelationshipType.hasDeclaredLicense,
            RelationshipType.hasDeletedFile,
            RelationshipType.hasDependencyManifest,
            RelationshipType.hasDistributionArtifact,
            RelationshipType.hasDocumentation,
            RelationshipType.hasDynamicLink,
            RelationshipType.hasEvidence,
            RelationshipType.hasExample,
            RelationshipType.hasHost,
            RelationshipType.hasInput,
            RelationshipType.hasMetadata,
            RelationshipType.hasOptionalComponent,
            RelationshipType.hasOptionalDependency,
            RelationshipType.hasOutput,
            RelationshipType.hasPrerequisite,
            RelationshipType.hasProvidedDependency,
            RelationshipType.hasRequirement,
            RelationshipType.hasSpecification,
            RelationshipType.hasStaticLink,
            RelationshipType.hasTest,
            RelationshipType.hasTestCase,
            RelationshipType.hasVariant,
            RelationshipType.invokedBy,
            RelationshipType.modifiedBy,
            RelationshipType.other,
            RelationshipType.packagedBy,
            RelationshipType.patchedBy,
            RelationshipType.publishedBy,
            RelationshipType.reportedBy,
            RelationshipType.republishedBy,
            RelationshipType.serializedInArtifact,
            RelationshipType.testedOn,
            RelationshipType.trainedOn,
            RelationshipType.underInvestigationFor,
            RelationshipType.usesTool
        };

        // Act
        var json = JsonSerializer.Serialize<object>(enumArray);

        const string expected = """
                                ["affects","amendedBy","ancestorOf","availableFrom","configures","contains","coordinatedBy","copiedTo","delegatedTo","dependsOn","descendantOf","describes","doesNotAffect","expandsTo","exploitCreatedBy","fixedBy","fixedIn","foundBy","generates","hasAddedFile","hasAssessmentFor","hasAssociatedVulnerability","hasConcludedLicense","hasDataFile","hasDeclaredLicense","hasDeletedFile","hasDependencyManifest","hasDistributionArtifact","hasDocumentation","hasDynamicLink","hasEvidence","hasExample","hasHost","hasInput","hasMetadata","hasOptionalComponent","hasOptionalDependency","hasOutput","hasPrerequisite","hasProvidedDependency","hasRequirement","hasSpecification","hasStaticLink","hasTest","hasTestCase","hasVariant","invokedBy","modifiedBy","other","packagedBy","patchedBy","publishedBy","reportedBy","republishedBy","serializedInArtifact","testedOn","trainedOn","underInvestigationFor","usesTool"]
                                """;

        // Assert
        Assert.Equal(expected, json);
    }
}