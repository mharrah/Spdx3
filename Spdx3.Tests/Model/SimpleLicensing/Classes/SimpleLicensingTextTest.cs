using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.SimpleLicensing.Classes;

public class SimpleLicensingTextTest : BaseModelTest
{
    [Fact]
    public void SimpleLicensingText_MinimallyPopulated_ShouldSerialize()
    {
        // Arrange
        var simpleLicensingText = new SimpleLicensingText(TestCatalog, TestCreationInfo, "MIT");

        const string expected = """
                                {
                                  "simplelicensing_licenseText": "MIT",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "simplelicensing_SimpleLicensingText",
                                  "spdxId": "urn:SimpleLicensingText:40f"
                                }
                                """;

        // Act
        var json = ToJson(simpleLicensingText);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void SimpleLicensingText_FullyPopulated_ShouldSerialize()
    {
        // Arrange
        var simpleLicensingText = new SimpleLicensingText(TestCatalog, TestCreationInfo, "MIT")
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        simpleLicensingText.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        simpleLicensingText.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        simpleLicensingText.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        simpleLicensingText.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));

        const string expected = """
                                {
                                  "simplelicensing_licenseText": "MIT",
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "extension": [
                                    "urn:ExtensionConcreteTestFixture:41c"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:429"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:436"
                                  ],
                                  "name": "TestName",
                                  "summary": "TestSummary",
                                  "verifiedUsing": [
                                    "urn:IntegrityMethodConcreteTestFixture:443"
                                  ],
                                  "type": "simplelicensing_SimpleLicensingText",
                                  "spdxId": "urn:SimpleLicensingText:40f"
                                }
                                """;

        // Act
        var json = ToJson(simpleLicensingText);

        // Assert
        Assert.Equal(expected, json);
    }
}