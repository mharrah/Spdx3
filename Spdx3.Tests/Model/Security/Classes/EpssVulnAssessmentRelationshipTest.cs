using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Security.Classes;

public class EpssVulnAssessmentRelationshipTest : BaseModelTestClass
{
        [Fact]
    public void EpssVulnAssessmentRelationship_MinimalObject_ShouldDeserialize()
    {
        // Arrange
        const string json = """
                            {
                              "security_percentile": 0.25,
                              "security_probability": 0.75,
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "security_EpssVulnAssessmentRelationship",
                              "spdxId": "urn:EpssVulnAssessmentRelationship:402"
                            }
                            """;

        // Act
        var epssVulnAssessmentRelationship = FromJson<EpssVulnAssessmentRelationship>(json);

        // Assert
        Assert.NotNull(epssVulnAssessmentRelationship);
        Assert.Equal("urn:EpssVulnAssessmentRelationship:402", epssVulnAssessmentRelationship.SpdxId);
    }


    [Fact]
    public void EpssVulnAssessmentRelationship_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var person = new Person(TestCatalog, TestCreationInfo);
        var agents = new List<Element> { new Agent(TestCatalog, TestCreationInfo) };
        var epssVulnAssessmentRelationship = new EpssVulnAssessmentRelationship(TestCatalog, TestCreationInfo,
            person, agents, 0.25, 0.75);
        const string expected = """
                                {
                                  "security_percentile": 0.25,
                                  "security_probability": 0.75,
                                  "from": "urn:Person:40f",
                                  "to": [
                                    "urn:Agent:41c"
                                  ],
                                  "relationshipType": "hasAssessmentFor",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "security_EpssVulnAssessmentRelationship",
                                  "spdxId": "urn:EpssVulnAssessmentRelationship:429"
                                }
                                """;

        // Act
        var json = ToJson(epssVulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void EpssVulnAssessmentRelationship_PopulatedObject_ShouldSerialize()
    {
        // Arrange
        var person = new Person(TestCatalog, TestCreationInfo);
        var agents = new List<Element> { new Agent(TestCatalog, TestCreationInfo) };
        var epssVulnAssessmentRelationship =
            new EpssVulnAssessmentRelationship(TestCatalog, TestCreationInfo, person, agents, 0.25, 0.75)
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
        epssVulnAssessmentRelationship.Extension.Add(new TestExtension(TestCatalog));
        epssVulnAssessmentRelationship.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog,
            ExternalIdentifierType.email, "example@example.com"));
        epssVulnAssessmentRelationship.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.documentation));
        epssVulnAssessmentRelationship.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.md2, "123"));

        const string expected = """
                                {
                                  "security_percentile": 0.25,
                                  "security_probability": 0.75,
                                  "security_suppliedBy": "urn:Person:436",
                                  "security_modifiedTime": "2025-02-23T01:23:45Z",
                                  "security_publishedTime": "2025-02-24T01:23:45Z",
                                  "security_withdrawnTime": "2025-02-25T01:23:45Z",
                                  "from": "urn:Person:40f",
                                  "to": [
                                    "urn:Agent:41c"
                                  ],
                                  "relationshipType": "hasAssessmentFor",
                                  "comment": "a comment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "a description",
                                  "extension": [
                                    "urn:TestExtension:443"
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
                                  "type": "security_EpssVulnAssessmentRelationship",
                                  "spdxId": "urn:EpssVulnAssessmentRelationship:429"
                                }
                                """;

        // Act
        var json = ToJson(epssVulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
        Assert.Equal(expected, json);
    }

    
}