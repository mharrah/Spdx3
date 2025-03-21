using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Security.Classes;

public class VulnAssessmentRelationshipTest : BaseModelTestClass
{
        [Fact]
    public void VulnAssessmentRelationship_MinimalObject_ShouldDeserialize()
    {
      // Arrange
      const string json = """
                              {
                                "creationInfo": "urn:CreationInfo:3f5",
                                "type": "security_VulnAssessmentRelationship",
                                "spdxId": "urn:VulnAssessmentRelationship:402"
                              }
                              """;
          
      // Act
      var vulnAssessmentRelationship = FromJson<VulnAssessmentRelationship>(json);
          
      // Assert
      Assert.NotNull(vulnAssessmentRelationship);
      Assert.Equal("urn:VulnAssessmentRelationship:402", vulnAssessmentRelationship.SpdxId);
    }


    [Fact]
    public void VulnAssessmentRelationship_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var person = new Person(TestCatalog, TestCreationInfo);
        var agents = new List<Element> { new Agent(TestCatalog, TestCreationInfo) };
        var vulnAssessmentRelationship = new VulnAssessmentRelationship(TestCatalog, TestCreationInfo, 
          RelationshipType.affects, person, agents);
        const string expected = """
                                {
                                  "from": "urn:Person:40f",
                                  "to": [
                                    "urn:Agent:41c"
                                  ],
                                  "relationshipType": "affects",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "security_VulnAssessmentRelationship",
                                  "spdxId": "urn:VulnAssessmentRelationship:429"
                                }
                                """;
        
        // Act
        var json = ToJson(vulnAssessmentRelationship);
        
        // Assert
        Assert.Equal(expected, json);
    }
    
    [Fact]
    public void VulnAssessmentRelationship_PopulatedObject_ShouldSerialize()
    {
        // Arrange
        var person = new Person(TestCatalog, TestCreationInfo);
        var agents = new List<Element> { new Agent(TestCatalog, TestCreationInfo) };
        var vulnAssessmentRelationship = new VulnAssessmentRelationship(TestCatalog, TestCreationInfo, RelationshipType.other, person, agents)
        {
            ModifiedTime = PredictableDateTime.AddDays(1),
            PublishedTime = PredictableDateTime.AddDays(2),
            WithdrawnTime = PredictableDateTime.AddDays(3),
            SuppliedBy = new Person(TestCatalog, TestCreationInfo),
            Comment = "a comment",
            Description = "a description",
            Summary = "a summary",
            Name = "a name",
        };
        vulnAssessmentRelationship.Extension.Add(new TestExtension(TestCatalog));
        vulnAssessmentRelationship.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        vulnAssessmentRelationship.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.documentation));
        vulnAssessmentRelationship.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.md2, "123"));

        const string expected = """
                                {
                                  "security_suppliedBy": "urn:Person:436",
                                  "security_modifiedTime": "2025-02-23T01:23:45Z",
                                  "security_publishedTime": "2025-02-24T01:23:45Z",
                                  "security_withdrawnTime": "2025-02-25T01:23:45Z",
                                  "from": "urn:Person:40f",
                                  "to": [
                                    "urn:Agent:41c"
                                  ],
                                  "relationshipType": "other",
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
                                  "type": "security_VulnAssessmentRelationship",
                                  "spdxId": "urn:VulnAssessmentRelationship:429"
                                }
                                """;
        
        // Act
        var json = ToJson(vulnAssessmentRelationship);
        
        // Assert
        Assert.Equal(expected, json);
    }

}