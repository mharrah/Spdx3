using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Tests.Model.Extension.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Security.Classes;

public class CvssV2VulnAssessmentRelationshipTest : BaseModelTest
{
    [Fact]
    public void CvssV2VulnAssessmentRelationship_MinimalObject_ShouldDeserialize()
    {
        // Arrange
        const string json = """
                            {
                              "security_score": 1.5,
                              "security_vectorString": "SQL injection",
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "security_CvssV2VulnAssessmentRelationship",
                              "spdxId": "urn:CvssV2VulnAssessmentRelationship:402"
                            }
                            """;

        // Act
        var cvssV2VulnAssessmentRelationship = FromJson<CvssV2VulnAssessmentRelationship>(json);

        // Assert
        Assert.NotNull(cvssV2VulnAssessmentRelationship);
        Assert.Equal(new Uri("urn:CvssV2VulnAssessmentRelationship:402"), cvssV2VulnAssessmentRelationship.SpdxId);
    }


    [Fact]
    public void CvssV2VulnAssessmentRelationship_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var cvssV2VulnAssessmentRelationship = new CvssV2VulnAssessmentRelationship(TestCatalog, TestCreationInfo,
            vulnerability, packages, 1.5, "SQL injection");
        const string expected = """
                                {
                                  "security_score": 1.5,
                                  "security_vectorString": "SQL injection",
                                  "from": "urn:Vulnerability:40f",
                                  "relationshipType": "hasAssessmentFor",
                                  "to": [
                                    "urn:Package:41c"
                                  ],
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "security_CvssV2VulnAssessmentRelationship",
                                  "spdxId": "urn:CvssV2VulnAssessmentRelationship:429"
                                }
                                """;

        // Act
        var json = ToJson(cvssV2VulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void CvssV2VulnAssessmentRelationship_PopulatedObject_ShouldSerialize()
    {
        // Arrange
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var cvssV2VulnAssessmentRelationship = new CvssV2VulnAssessmentRelationship(TestCatalog, TestCreationInfo,
            vulnerability, packages, 1.5, "SQL injection")
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
        cvssV2VulnAssessmentRelationship.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        cvssV2VulnAssessmentRelationship.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog,
            ExternalIdentifierType.email, "example@example.com"));
        cvssV2VulnAssessmentRelationship.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.documentation));
        cvssV2VulnAssessmentRelationship.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.md2, "123"));

        const string expected = """
                                {
                                  "security_score": 1.5,
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
                                  "type": "security_CvssV2VulnAssessmentRelationship",
                                  "spdxId": "urn:CvssV2VulnAssessmentRelationship:429"
                                }
                                """;

        // Act
        var json = ToJson(cvssV2VulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void Validation_FailsWhen_RelationshipType_WrongValue()
    {
        // Arrange
        var cvssV2VulnAssessmentRelationship = IncompleteObjectFactory.Create<CvssV2VulnAssessmentRelationship>();
        cvssV2VulnAssessmentRelationship.Type = "CvssV2VulnAssessmentRelationship";
        cvssV2VulnAssessmentRelationship.SpdxId = new Uri("urn:CvssV2VulnAssessmentRelationship:429a");
        cvssV2VulnAssessmentRelationship.CreationInfo = TestCreationInfo;
        cvssV2VulnAssessmentRelationship.From = IncompleteObjectFactory.Create<Package>();
        cvssV2VulnAssessmentRelationship.To = [IncompleteObjectFactory.Create<Package>()];
        cvssV2VulnAssessmentRelationship.RelationshipType = RelationshipType.other;
        cvssV2VulnAssessmentRelationship.Score = 1.0;
        cvssV2VulnAssessmentRelationship.VectorString = "vector";

        // Act
        var exc = Record.Exception(() => cvssV2VulnAssessmentRelationship.Validate());

        // Assert
        Assert.NotNull(exc);
        Assert.IsType<Spdx3ValidationException>(exc);
        Assert.Contains("Must be 'hasAssessmentFor'", exc.Message);
    }
}