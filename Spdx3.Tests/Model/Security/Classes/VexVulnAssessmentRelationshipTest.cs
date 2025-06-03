using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Security.Classes;

/// <summary>
///     Test for the VexVulnAssessmentRelationship abstract class, using VexVulnAssessmentRelationshipConcreteTestFixture as the concrete
///     implementation.
/// </summary>
public class VexVulnAssessmentRelationshipTest : BaseModelTest
{
    [Fact]
    public void VexVulnAssessmentRelationship_MinimalObject_ShouldDeserialize()
    {
        // Arrange
        const string json = """
                            {
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "security_VexVulnAssessmentRelationship",
                              "spdxId": "urn:VexVulnAssessmentRelationship:402"
                            }
                            """;

        // Act
        var vexVulnAssessmentRelationship = FromJson<VexVulnAssessmentRelationshipConcreteTestFixture>(json);

        // Assert
        Assert.NotNull(vexVulnAssessmentRelationship);
        Assert.Equal(new Uri("urn:VexVulnAssessmentRelationship:402"), vexVulnAssessmentRelationship.SpdxId);
    }


    [Fact]
    public void VexVulnAssessmenRelationship_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var vexVulnAssessmentRelationship = new VexVulnAssessmentRelationshipConcreteTestFixture(TestCatalog, TestCreationInfo,
            RelationshipType.affects, vulnerability, packages);
        const string expected = """
                                {
                                  "from": "urn:Vulnerability:40f",
                                  "relationshipType": "affects",
                                  "to": [
                                    "urn:Package:41c"
                                  ],
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "security_VexVulnAssessmentRelationshipConcreteTestFixture",
                                  "spdxId": "urn:VexVulnAssessmentRelationshipConcreteTestFixture:429"
                                }
                                """;

        // Act
        var json = ToJson(vexVulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void VexVulnAssessmenRelationship_PopulatedObject_ShouldSerialize()
    {
        // Arrange
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var vexVulnAssessmentRelationship =
            new VexVulnAssessmentRelationshipConcreteTestFixture(TestCatalog, TestCreationInfo, RelationshipType.other, vulnerability,
                packages)
            {
                ModifiedTime = PredictableDateTime.AddDays(1),
                PublishedTime = PredictableDateTime.AddDays(2),
                WithdrawnTime = PredictableDateTime.AddDays(3),
                SuppliedBy = new Person(TestCatalog, TestCreationInfo),
                Comment = "a comment",
                Description = "a description",
                Summary = "a summary",
                Name = "a name"
            };
        vexVulnAssessmentRelationship.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        vexVulnAssessmentRelationship.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog,
            ExternalIdentifierType.email, "example@example.com"));
        vexVulnAssessmentRelationship.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.documentation));
        vexVulnAssessmentRelationship.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.md2, "123"));

        const string expected = """
                                {
                                  "security_modifiedTime": "2025-02-23T01:23:45Z",
                                  "security_publishedTime": "2025-02-24T01:23:45Z",
                                  "security_suppliedBy": "urn:Person:436",
                                  "security_withdrawnTime": "2025-02-25T01:23:45Z",
                                  "from": "urn:Vulnerability:40f",
                                  "relationshipType": "other",
                                  "to": [
                                    "urn:Package:41c"
                                  ],
                                  "comment": "a comment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "a description",
                                  "extension": [
                                    "urn:ExtensionConcreteTestFixture:443"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:450"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:45d"
                                  ],
                                  "name": "a name",
                                  "summary": "a summary",
                                  "verifiedUsing": [
                                    "urn:Hash:46a"
                                  ],
                                  "type": "security_VexVulnAssessmentRelationshipConcreteTestFixture",
                                  "spdxId": "urn:VexVulnAssessmentRelationshipConcreteTestFixture:429"
                                }
                                """;

        // Act
        var json = ToJson(vexVulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
    }
}