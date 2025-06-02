using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

public class CustomLicenseAdditionTest : BaseModelTest
{
    [Fact]
    public void BrandNew_CustomLicenseAddition_SerializesProperly()
    {
        // Arrange
        var customLicenseAddition = new CustomLicenseAddition(TestCatalog, TestCreationInfo, "Test Addition Text");
        const string expected = """
                                {
                                  "expandedlicensing_additionText": "Test Addition Text",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "expandedlicensing_CustomLicenseAddition",
                                  "spdxId": "urn:CustomLicenseAddition:40f"
                                }
                                """;

        // Act
        var json = ToJson(customLicenseAddition);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_CustomLicenseAddition_SerializesProperly()
    {
        // Arrange
        var customLicenseAddition = new CustomLicenseAddition(TestCatalog, TestCreationInfo, "Test Addition Text")
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        customLicenseAddition.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        customLicenseAddition.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email,
            "example@example.com"));
        customLicenseAddition.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        customLicenseAddition.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));

        const string expected = """
                                {
                                  "expandedlicensing_additionText": "Test Addition Text",
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
                                  "type": "expandedlicensing_CustomLicenseAddition",
                                  "spdxId": "urn:CustomLicenseAddition:40f"
                                }
                                """;

        // Act
        var json = ToJson(customLicenseAddition);

        // Assert
        Assert.Equal(expected, json);
    }
}