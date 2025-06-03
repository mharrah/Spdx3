using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Classes;
using Spdx3.Model.Security.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Security.Classes;

public class SsvcVulnAssessmentRelationshipTest : BaseModelTest
{
    [Fact]
    public void SsvcVulnAssessmentRelationship_MinimalObject_ShouldDeserialize()
    {
        // Arrange
        const string json = """
                            {
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "security_SsvcVulnAssessmentRelationship",
                              "spdxId": "urn:SsvcVulnAssessmentRelationship:402"
                            }
                            """;

        // Act
        var ssvcVulnAssessmentRelationship = FromJson<SsvcVulnAssessmentRelationship>(json);

        // Assert
        Assert.NotNull(ssvcVulnAssessmentRelationship);
        Assert.Equal(new Uri("urn:SsvcVulnAssessmentRelationship:402"), ssvcVulnAssessmentRelationship.SpdxId);
    }


    [Fact]
    public void SsvcVulnAssessmentRelationship_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var ssvcVulnAssessmentRelationship = new SsvcVulnAssessmentRelationship(TestCatalog, TestCreationInfo,
            vulnerability, packages, SsvcDecisionType.track);
        const string expected = """
                                {
                                  "security_decisionType": "track",
                                  "from": "urn:Vulnerability:40f",
                                  "relationshipType": "hasAssessmentFor",
                                  "to": [
                                    "urn:Package:41c"
                                  ],
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "security_SsvcVulnAssessmentRelationship",
                                  "spdxId": "urn:SsvcVulnAssessmentRelationship:429"
                                }
                                """;

        // Act
        var json = ToJson(ssvcVulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void SsvcVulnAssessmentRelationship_PopulatedObject_ShouldSerialize()
    {
        // Arrange
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var ssvcVulnAssessmentRelationship =
            new SsvcVulnAssessmentRelationship(TestCatalog, TestCreationInfo, vulnerability, packages, SsvcDecisionType.track)
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
        ssvcVulnAssessmentRelationship.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        ssvcVulnAssessmentRelationship.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog,
            ExternalIdentifierType.email, "example@example.com"));
        ssvcVulnAssessmentRelationship.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.documentation));
        ssvcVulnAssessmentRelationship.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.md2, "123"));

        const string expected = """
                                {
                                  "security_decisionType": "track",
                                  "security_modifiedTime": "2025-02-23T01:23:45Z",
                                  "security_publishedTime": "2025-02-24T01:23:45Z",
                                  "security_suppliedBy": "urn:Person:436",
                                  "security_withdrawnTime": "2025-02-25T01:23:45Z",
                                  "from": "urn:Vulnerability:40f",
                                  "relationshipType": "hasAssessmentFor",
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
                                  "type": "security_SsvcVulnAssessmentRelationship",
                                  "spdxId": "urn:SsvcVulnAssessmentRelationship:429"
                                }
                                """;

        // Act
        var json = ToJson(ssvcVulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
        Assert.Equal(expected, json);
    }
    
}