using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Security.Classes;
using Spdx3.Model.Security.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Security.Classes;

public class VexNotAffectedVulnAssessmentRelationshipTest : BaseModelTestClass
{
    [Fact]
    public void VexNotAffectedVulnAssessmentRelationship_MinimalObject_ShouldDeserialize()
    {
        // Arrange
        const string json = """
                            {
                              "creationInfo": "urn:CreationInfo:3f5",
                              "type": "security_VexVulnAssessmentRelationship",
                              "spdxId": "urn:VexNotAffectedVulnAssessmentRelationship:402"
                            }
                            """;

        // Act
        var vv = FromJson<VexNotAffectedVulnAssessmentRelationship>(json);

        // Assert
        Assert.NotNull(vv);
        Assert.Equal(new Uri("urn:VexNotAffectedVulnAssessmentRelationship:402"), vv.SpdxId);
    }


    [Fact]
    public void VexVulnAssessmentRelationship_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var vexVulnAssessmentRelationship = new VexNotAffectedVulnAssessmentRelationship(TestCatalog, TestCreationInfo,
            vulnerability, packages)
        {
            JustificationType = VexJustificationType.inlineMitigationsAlreadyExist
        };
        const string expected = """
                                {
                                  "security_justificationType": "inlineMitigationsAlreadyExist",
                                  "from": "urn:Vulnerability:40f",
                                  "to": [
                                    "urn:Package:41c"
                                  ],
                                  "relationshipType": "doesNotAffect",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "security_VexNotAffectedVulnAssessmentRelationship",
                                  "spdxId": "urn:VexNotAffectedVulnAssessmentRelationship:429"
                                }
                                """;

        // Act
        var json = ToJson(vexVulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void VexNotAffectedVulnAssessmentRelationship_Requires_ImpactStatement_AndOr_JustificationType()
    {
        // Arrange
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var vv = new VexNotAffectedVulnAssessmentRelationship(TestCatalog, TestCreationInfo, vulnerability, packages)
        {
            ImpactStatement = "not null",
            JustificationType = VexJustificationType.componentNotPresent
        };

        
        // Act and Assert
        vv.Validate();
        
        vv.ImpactStatement = "not null";
        vv.JustificationType = null;
        vv.Validate();

        vv.ImpactStatement = null;
        vv.JustificationType = VexJustificationType.componentNotPresent;
        vv.Validate();

        vv.ImpactStatement = null;
        vv.JustificationType = null;
        Assert.Throws<Spdx3ValidationException>(() => vv.Validate());
    }
    
    [Fact]
    public void VexNotAffectedVulnAssessmentRelationship_PopulatedObject_ShouldSerialize()
    {
        // Arrange
        var vulnerability = new Vulnerability(TestCatalog, TestCreationInfo);
        var packages = new List<Element> { new Package(TestCatalog, TestCreationInfo) };
        var vexVulnAssessmentRelationship =
            new VexNotAffectedVulnAssessmentRelationship(TestCatalog, TestCreationInfo, vulnerability, packages)
            {
                ModifiedTime = PredictableDateTime.AddDays(1),
                PublishedTime = PredictableDateTime.AddDays(2),
                WithdrawnTime = PredictableDateTime.AddDays(3),
                SuppliedBy = new Person(TestCatalog, TestCreationInfo),
                Comment = "a comment",
                Description = "a description",
                Summary = "a summary",
                Name = "a name",
                JustificationType = VexJustificationType.vulnerableCodeNotPresent,
                ImpactStatement = "Wam! Bam! Oof!"
            };
        vexVulnAssessmentRelationship.Extension.Add(new TestExtension(TestCatalog));
        vexVulnAssessmentRelationship.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog,
            ExternalIdentifierType.email, "example@example.com"));
        vexVulnAssessmentRelationship.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.documentation));
        vexVulnAssessmentRelationship.VerifiedUsing.Add(new Hash(TestCatalog, HashAlgorithm.md2, "123"));

        const string expected = """
                                {
                                  "security_impactStatement": "Wam! Bam! Oof!",
                                  "security_justificationType": "vulnerableCodeNotPresent",
                                  "security_suppliedBy": "urn:Person:436",
                                  "security_modifiedTime": "2025-02-23T01:23:45Z",
                                  "security_publishedTime": "2025-02-24T01:23:45Z",
                                  "security_withdrawnTime": "2025-02-25T01:23:45Z",
                                  "from": "urn:Vulnerability:40f",
                                  "to": [
                                    "urn:Package:41c"
                                  ],
                                  "relationshipType": "doesNotAffect",
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
                                  "type": "security_VexNotAffectedVulnAssessmentRelationship",
                                  "spdxId": "urn:VexNotAffectedVulnAssessmentRelationship:429"
                                }
                                """;

        // Act
        var json = ToJson(vexVulnAssessmentRelationship);

        // Assert
        Assert.Equal(expected, json);
    }

}