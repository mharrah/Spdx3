using System.Reflection;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Tests.Model.Extension.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Security.Classes;

public class EpssVulnAssessmentRelationshipTest : BaseModelTest
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
        Assert.Equal(new Uri("urn:EpssVulnAssessmentRelationship:402"), epssVulnAssessmentRelationship.SpdxId);
    }

    [Fact]
    public void EpssVulnAssessmentRelationship_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var epssVulnAssessmentRelationship = new EpssVulnAssessmentRelationship(TestCatalog, TestCreationInfo,
            vulnerability, packages, 0.25, 0.75);
        const string expected = """
                                {
                                  "security_percentile": 0.25,
                                  "security_probability": 0.75,
                                  "from": "urn:Vulnerability:40f",
                                  "relationshipType": "hasAssessmentFor",
                                  "to": [
                                    "urn:Package:41c"
                                  ],
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
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var epssVulnAssessmentRelationship =
            new EpssVulnAssessmentRelationship(TestCatalog, TestCreationInfo, vulnerability, packages, 0.25, 0.75)
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
        epssVulnAssessmentRelationship.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        epssVulnAssessmentRelationship.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog,
            ExternalIdentifierType.email, "example@example.com"));
        epssVulnAssessmentRelationship.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.documentation));
        epssVulnAssessmentRelationship.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.md2, "123"));

        const string expected = """
                                {
                                  "security_percentile": 0.25,
                                  "security_probability": 0.75,
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

    [Fact]
    public void EpssVulnAssessmentRelationship_Percentile_ConstrainedToRange()
    {
        // Arrange
        var epssVulnAssessmentRelationship = IncompleteObjectFactory.Create<EpssVulnAssessmentRelationship>();
        
        // Act and Assert
        Assert.Throws<Spdx3Exception>(() => epssVulnAssessmentRelationship.Percentile = 1.00000001);
        Assert.Throws<Spdx3Exception>(() => epssVulnAssessmentRelationship.Percentile = -0.00000001);

        var exception = Record.Exception(() => epssVulnAssessmentRelationship.Percentile = 0.0);
        Assert.Null(exception);
        
        exception = Record.Exception(() => epssVulnAssessmentRelationship.Percentile = 1.0);
        Assert.Null(exception);

    }

    [Fact]
    public void EpssVulnAssessmentRelationship_FailsDeserializationWhen_Percentile_LessThanZero()
    {
        // Arrange
        const string json = """
                            {
                              "security_percentile": -0.000000001,
                              "security_probability": 0.5,
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "security_EpssVulnAssessmentRelationship",
                              "spdxId": "urn:EpssVulnAssessmentRelationship:402"
                            }
                            """;

        // Act and Assert
        Assert.Throws<TargetInvocationException>(() => FromJson<EpssVulnAssessmentRelationship>(json));
    }
    
    [Fact]
    public void EpssVulnAssessmentRelationship_FailsDeserializationWhen_Percentile_GreaterThanOne()
    {
        // Arrange
        const string json = """
                            {
                              "security_percentile": 1.0000001,
                              "security_probability": 0.5,
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "security_EpssVulnAssessmentRelationship",
                              "spdxId": "urn:EpssVulnAssessmentRelationship:402"
                            }
                            """;

        // Act and Assert
        Assert.Throws<TargetInvocationException>(() => FromJson<EpssVulnAssessmentRelationship>(json));
        
    }

    [Fact]
    public void EpssVulnAssessmentRelationship_Probability_ConstrainedToRange()
    {
        // Arrange
        var epssVulnAssessmentRelationship = IncompleteObjectFactory.Create<EpssVulnAssessmentRelationship>();
        
        // Act and Assert
        Assert.Throws<Spdx3Exception>(() => epssVulnAssessmentRelationship.Probability = 1.00000001);
        Assert.Throws<Spdx3Exception>(() => epssVulnAssessmentRelationship.Probability = -0.00000001);

        var exception = Record.Exception(() => epssVulnAssessmentRelationship.Probability = 0.0);
        Assert.Null(exception);
        
        exception = Record.Exception(() => epssVulnAssessmentRelationship.Probability = 1.0);
        Assert.Null(exception);

    }
    
    [Fact]
    public void EpssVulnAssessmentRelationship_FailsDeserializationWhen_Probability_LessThanZero()
    {
        // Arrange
        const string json = """
                            {
                              "security_percentile": 0.25,
                              "security_probability": -0.09,
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "security_EpssVulnAssessmentRelationship",
                              "spdxId": "urn:EpssVulnAssessmentRelationship:402"
                            }
                            """;

        // Act and Assert
        Assert.Throws<TargetInvocationException>(() => FromJson<EpssVulnAssessmentRelationship>(json));
    }
    
    [Fact]
    public void EpssVulnAssessmentRelationship_FailsDeserializationWhen_Probability_GreaterThanOne()
    {
        // Arrange
        const string json = """
                            {
                              "security_percentile": 0.25,
                              "security_probability": 1.000001,
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "security_EpssVulnAssessmentRelationship",
                              "spdxId": "urn:EpssVulnAssessmentRelationship:402"
                            }
                            """;

        // Act and Assert
        Assert.Throws<TargetInvocationException>(() => FromJson<EpssVulnAssessmentRelationship>(json));
        
    }
    

}