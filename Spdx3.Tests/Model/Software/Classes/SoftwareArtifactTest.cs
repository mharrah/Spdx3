using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Software.Classes;

public class SoftwareArtifactTest : BaseModelTestClass
{
    [Fact]
    public void SoftwareArtifact_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var softwareArtifact = new TestSoftwareArtifact(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "software_TestSoftwareArtifact",
                                  "spdxId": "urn:TestSoftwareArtifact:402"
                                }
                                """;

        // Act
        var json = ToJson(softwareArtifact);

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void SoftwareArtifact_FullyPopulated_ShouldSerialize()
    {
        // Arrange
        var softwareArtifact = new TestSoftwareArtifact(TestCatalog, TestCreationInfo)
        {
            Comment = "Some comment",
            Description = "Some description",
            Name = "Some name",
            Summary = "Some summary",
            BuiltTime = PredictableDateTime,
            CopyrightText = "Some copyright text",
            PrimaryPurpose = SoftwarePurpose.application,
            ReleaseTime = PredictableDateTime,
            StandardName = "Some standard name",
            ValidUntilTime = PredictableDateTime,
            SuppliedBy = new Agent(TestCatalog, TestCreationInfo)
        };
        softwareArtifact.SupportLevel.Add(SupportType.noAssertion);
        softwareArtifact.VerifiedUsing.Add(new TestIntegrityMethod(TestCatalog));
        softwareArtifact.AdditionalPurpose.Add(SoftwarePurpose.archive);
        softwareArtifact.OriginatedBy.Add(new Agent(TestCatalog, TestCreationInfo));
        softwareArtifact.ContentIdentifier.Add(new ContentIdentifier(TestCatalog, ContentIdentifierType.gitoid,
            "some gitoid value"));
        softwareArtifact.AttributionText.Add("Some attribution text");
        softwareArtifact.AdditionalPurpose.Add(SoftwarePurpose.other);
        softwareArtifact.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.bower));
        softwareArtifact.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.cpe23,
            "cpe23 identifier"));
        softwareArtifact.Extension.Add(new TestExtension(TestCatalog));
        const string expected = """
                                {
                                  "additionalPurpose": [
                                    "archive",
                                    "other"
                                  ],
                                  "contentIdentifier": [
                                    "urn:ContentIdentifier:436"
                                  ],
                                  "primaryPurpose": "application",
                                  "attributionText": [
                                    "Some attribution text"
                                  ],
                                  "builtTime": "2025-02-22T01:23:45Z",
                                  "originatedBy": [
                                    "urn:Agent:429"
                                  ],
                                  "releaseTime": "2025-02-22T01:23:45Z",
                                  "standardName": "Some standard name",
                                  "suppliedBy": "urn:Agent:40f",
                                  "supportLevel": [
                                    "noAssertion"
                                  ],
                                  "validUntilTime": "2025-02-22T01:23:45Z",
                                  "comment": "Some comment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "Some description",
                                  "extension": [
                                    "urn:TestExtension:45d"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:450"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:443"
                                  ],
                                  "name": "Some name",
                                  "summary": "Some summary",
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:41c"
                                  ],
                                  "type": "software_TestSoftwareArtifact",
                                  "spdxId": "urn:TestSoftwareArtifact:402"
                                }
                                """;

        // Act
        var json = ToJson(softwareArtifact);

        // Assert
        Assert.Equal(expected, json);
    }
}