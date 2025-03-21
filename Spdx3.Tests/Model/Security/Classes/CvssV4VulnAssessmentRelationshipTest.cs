using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Classes;
using Spdx3.Model.Security.Enums;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Security.Classes;

public class CvssV4VulnAssessmentRelationshipTest : BaseModelTestClass
{
    [Fact]
    public void CvssV4VulnAssessmentRelationship_MinimalObject_ShouldDeserialize()
    {
        // Arrange
        const string json = """
                            {
                              "security_score": 1.5,
                              "security_severity": "high",
                              "security_vectorString": "SQL injection",
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "security_CvssV4VulnAssessmentRelationship",
                              "spdxId": "urn:CvssV4VulnAssessmentRelationship:402"
                            }
                            """;

        // Act
        var cvssV4VulnAssessmentRelationship = FromJson<CvssV4VulnAssessmentRelationship>(json);

        // Assert
        Assert.NotNull(cvssV4VulnAssessmentRelationship);
        Assert.Equal("urn:CvssV4VulnAssessmentRelationship:402", cvssV4VulnAssessmentRelationship.SpdxId);
    }


    [Fact]
    public void CvssV4VulnAssessmentRelationship_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var person = new Person(TestCatalog, TestCreationInfo);
        var agents = new List<Element> { new Agent(TestCatalog, TestCreationInfo) };
        var cvssV4VulnAssessmentRelationship = new CvssV4VulnAssessmentRelationship(TestCatalog, TestCreationInfo,
            person, agents, 1.5, CvssSeverityType.high, "SQL injection");
        const string expected = """
                                {
                                  "security_score": 1.5,
                                  "security_severity": "high",
                                  "security_vectorString": "SQL injection",
                                  "from": "urn:Person:40f",
                                  "to": [
                                    "urn:Agent:41c"
                                  ],
                                  "relationshipType": "hasAssessmentFor",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "security_CvssV4VulnAssessmentRelationship",
                                  "spdxId": "urn:CvssV4VulnAssessmentRelationship:429"
                                }
                                """;

        // Act
        var json = ToJson(cvssV4VulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void CvssV4VulnAssessmentRelationship_PopulatedObject_ShouldSerialize()
    {
        // Arrange
        var person = new Person(TestCatalog, TestCreationInfo);
        var agents = new List<Element> { new Agent(TestCatalog, TestCreationInfo) };
        var cvssV4VulnAssessmentRelationship =
            new CvssV4VulnAssessmentRelationship(TestCatalog, TestCreationInfo, person, agents, 1.5, 
                CvssSeverityType.high, "SQL injection")
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
        cvssV4VulnAssessmentRelationship.Extension.Add(new TestExtension(TestCatalog));
        cvssV4VulnAssessmentRelationship.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog,
            ExternalIdentifierType.email, "example@example.com"));
        cvssV4VulnAssessmentRelationship.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.documentation));
        cvssV4VulnAssessmentRelationship.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.md2, "123"));

        const string expected = """
                                {
                                  "security_score": 1.5,
                                  "security_severity": "high",
                                  "security_vectorString": "SQL injection",
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
                                  "type": "security_CvssV4VulnAssessmentRelationship",
                                  "spdxId": "urn:CvssV4VulnAssessmentRelationship:429"
                                }
                                """;

        // Act
        var json = ToJson(cvssV4VulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
        Assert.Equal(expected, json);
    }
    
}