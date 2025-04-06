using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

public class ListedLicenseExceptionTest : BaseModelTest
{
    [Fact]
    public void BrandNew_ListedLicenseException_SerializesProperly()
    {
        // Arrange
        var listedLicenseException = new ListedLicenseException(TestCatalog, TestCreationInfo, "Test Addition Text");
        const string expected = """
                                {
                                  "expandedlicensing_additionText": "Test Addition Text",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "expandedlicensing_ListedLicenseException",
                                  "spdxId": "urn:ListedLicenseException:40f"
                                }
                                """;

        // Act
        var json = ToJson(listedLicenseException);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_ListedLicenseException_SerializesProperly()
    {
        // Arrange
        var listedLicenseException = new ListedLicenseException(TestCatalog, TestCreationInfo, "Test Addition Text")
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        listedLicenseException.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        listedLicenseException.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        listedLicenseException.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        listedLicenseException.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));


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
                                  "type": "expandedlicensing_ListedLicenseException",
                                  "spdxId": "urn:ListedLicenseException:40f"
                                }
                                """;

        // Act
        var json = ToJson(listedLicenseException);

        // Assert
        Assert.Equal(expected, json);
    }
}