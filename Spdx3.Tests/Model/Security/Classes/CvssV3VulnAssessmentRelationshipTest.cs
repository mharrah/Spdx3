using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Classes;
using Spdx3.Model.Security.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Tests.Model.Extension.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Security.Classes;

public class CvssV3VulnAssessmentRelationshipTest : BaseModelTest
{
    [Fact]
    public void CvssV3VulnAssessmentRelationship_MinimalObject_ShouldDeserialize()
    {
        // Arrange
        const string json = """
                            {
                              "security_score": 1.5,
                              "security_severity": "high",
                              "security_vectorString": "SQL injection",
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "security_CvssV3VulnAssessmentRelationship",
                              "spdxId": "urn:CvssV3VulnAssessmentRelationship:402"
                            }
                            """;

        // Act
        var cvssV3VulnAssessmentRelationship = FromJson<CvssV3VulnAssessmentRelationship>(json);

        // Assert
        Assert.NotNull(cvssV3VulnAssessmentRelationship);
        Assert.Equal(new Uri("urn:CvssV3VulnAssessmentRelationship:402"), cvssV3VulnAssessmentRelationship.SpdxId);
    }


    [Fact]
    public void CvssV3VulnAssessmentRelationship_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var cvssV3VulnAssessmentRelationship = new CvssV3VulnAssessmentRelationship(TestCatalog, TestCreationInfo,
            vulnerability, packages, 1.5,   CvssSeverityType.high, "SQL injection");
        const string expected = """
                                {
                                  "security_score": 1.5,
                                  "security_severity": "high",
                                  "security_vectorString": "SQL injection",
                                  "from": "urn:Vulnerability:40f",
                                  "relationshipType": "hasAssessmentFor",
                                  "to": [
                                    "urn:Package:41c"
                                  ],
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "security_CvssV3VulnAssessmentRelationship",
                                  "spdxId": "urn:CvssV3VulnAssessmentRelationship:429"
                                }
                                """;

        // Act
        var json = ToJson(cvssV3VulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void CvssV3VulnAssessmentRelationship_PopulatedObject_ShouldSerialize()
    {
        // Arrange
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var cvssV3VulnAssessmentRelationship =
            new CvssV3VulnAssessmentRelationship(TestCatalog, TestCreationInfo, vulnerability, packages, 1.5, 
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
        cvssV3VulnAssessmentRelationship.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        cvssV3VulnAssessmentRelationship.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog,
            ExternalIdentifierType.email, "example@example.com"));
        cvssV3VulnAssessmentRelationship.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.documentation));
        cvssV3VulnAssessmentRelationship.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.md2, "123"));

        const string expected = """
                                {
                                  "security_score": 1.5,
                                  "security_severity": "high",
                                  "security_vectorString": "SQL injection",
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
                                  "type": "security_CvssV3VulnAssessmentRelationship",
                                  "spdxId": "urn:CvssV3VulnAssessmentRelationship:429"
                                }
                                """;

        // Act
        var json = ToJson(cvssV3VulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
        Assert.Equal(expected, json);
    }
    
    
    
    [Fact]
    public void Validation_FailsWhen_RelationshipType_WrongValue()
    {
        // Arrange
        var cvssV3VulnAssessmentRelationship = IncompleteObjectFactory.Create<CvssV3VulnAssessmentRelationship>();
        cvssV3VulnAssessmentRelationship.Type = "CvssV3VulnAssessmentRelationship";
        cvssV3VulnAssessmentRelationship.SpdxId = new Uri("urn:CvssV3VulnAssessmentRelationship:429a");
        cvssV3VulnAssessmentRelationship.RelationshipType = RelationshipType.other;
        cvssV3VulnAssessmentRelationship.CreationInfo = TestCreationInfo;
        cvssV3VulnAssessmentRelationship.From = IncompleteObjectFactory.Create<Package>();
        cvssV3VulnAssessmentRelationship.To = [IncompleteObjectFactory.Create<Package>()];
        cvssV3VulnAssessmentRelationship.RelationshipType = RelationshipType.other;
        cvssV3VulnAssessmentRelationship.Score = 1.0;
        cvssV3VulnAssessmentRelationship.Severity = CvssSeverityType.low;
        cvssV3VulnAssessmentRelationship.VectorString = "vector";

        // Act
        var exc = Record.Exception(() => cvssV3VulnAssessmentRelationship.Validate());
        
        // Assert
        Assert.NotNull(exc);
        Assert.IsType<Spdx3ValidationException>(exc);
        Assert.Contains("Must be 'hasAssessmentFor'", exc.Message);
    }

}