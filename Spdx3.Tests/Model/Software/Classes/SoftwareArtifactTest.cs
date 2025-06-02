using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Software.Classes;

public class SoftwareArtifactTest : BaseModelTest
{
    [Fact]
    public void SoftwareArtifact_FullyPopulated_ShouldSerialize()
    {
        // Arrange
        var softwareArtifact = new SoftwareArtifactConcreteTestFixture(TestCatalog, TestCreationInfo)
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
        softwareArtifact.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));
        softwareArtifact.AdditionalPurpose.Add(SoftwarePurpose.archive);
        softwareArtifact.OriginatedBy.Add(new Agent(TestCatalog, TestCreationInfo));
        softwareArtifact.ContentIdentifier.Add(new ContentIdentifier(TestCatalog, ContentIdentifierType.gitoid,
            new Uri("urn:some-gitoid-value")));
        softwareArtifact.AttributionText.Add("Some attribution text");
        softwareArtifact.AdditionalPurpose.Add(SoftwarePurpose.other);
        softwareArtifact.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.bower));
        softwareArtifact.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.cpe23,
            "cpe23 identifier"));
        softwareArtifact.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        const string expected = """
                                {
                                  "software_additionalPurpose": [
                                    "archive",
                                    "other"
                                  ],
                                  "software_contentIdentifier": [
                                    "urn:ContentIdentifier:443"
                                  ],
                                  "software_primaryPurpose": "application",
                                  "software_attributionText": [
                                    "Some attribution text"
                                  ],
                                  "builtTime": "2025-02-22T01:23:45Z",
                                  "originatedBy": [
                                    "urn:Agent:436"
                                  ],
                                  "releaseTime": "2025-02-22T01:23:45Z",
                                  "standardName": "Some standard name",
                                  "suppliedBy": "urn:Agent:41c",
                                  "supportLevel": [
                                    "noAssertion"
                                  ],
                                  "validUntilTime": "2025-02-22T01:23:45Z",
                                  "comment": "Some comment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "Some description",
                                  "extension": [
                                    "urn:ExtensionConcreteTestFixture:46a"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:45d"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:450"
                                  ],
                                  "name": "Some name",
                                  "summary": "Some summary",
                                  "verifiedUsing": [
                                    "urn:IntegrityMethodConcreteTestFixture:429"
                                  ],
                                  "type": "software_SoftwareArtifactConcreteTestFixture",
                                  "spdxId": "urn:SoftwareArtifactConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(softwareArtifact);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void SoftwareArtifact_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var softwareArtifact = new SoftwareArtifactConcreteTestFixture(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "software_SoftwareArtifactConcreteTestFixture",
                                  "spdxId": "urn:SoftwareArtifactConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(softwareArtifact);

        // Assert
        Assert.Equal(expected, json);
    }
}