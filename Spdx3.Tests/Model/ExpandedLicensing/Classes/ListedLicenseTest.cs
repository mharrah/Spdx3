using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

public class ListedLicenseTest : BaseModelTest
{
    [Fact]
    public void BrandNew_ListedLicense_SerializesProperly()
    {
        // Arrange
        var listedLicense = new ListedLicense(TestCatalog, TestCreationInfo, "test license text");
        const string expected = """
                                {
                                  "simplelicensing_licenseText": "test license text",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "expandedlicensing_ListedLicense",
                                  "spdxId": "urn:ListedLicense:40f"
                                }
                                """;

        // Act
        var json = ToJson(listedLicense);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_ListedLicense_SerializesProperly()
    {
        // Arrange
        var listedLicense = new ListedLicense(TestCatalog, TestCreationInfo, "TestLicenseText")
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary",
            LicenseXml = "TestLicenseXml",
            ObsoletedBy = "TestObsoletedBy",
            IsFsfLibre = false,
            IsOsiApproved = true,
            IsDeprecatedLicenseId = false,
            StandardLicenseHeader = "TestStandardLicenseHeader",
            StandardLicenseTemplate = "TestStandardLicenseTemplate"
        };
        listedLicense.SeeAlso.Add(new Uri("https://something.com"));
        listedLicense.SeeAlso.Add(new Uri("https://somethingelse.com"));
        listedLicense.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        listedLicense.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        listedLicense.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        listedLicense.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));


        const string expected = """
                                {
                                  "simplelicensing_licenseText": "TestLicenseText",
                                  "expandedlicensing_isDeprecatedLicenseId": false,
                                  "expandedlicensing_isFsfLibre": false,
                                  "expandedlicensing_isOsiApproved": true,
                                  "expandedlicensing_licenseXml": "TestLicenseXml",
                                  "expandedlicensing_obsoletedBy": "TestObsoletedBy",
                                  "expandedlicensing_seeAlso": [
                                    "https://something.com/",
                                    "https://somethingelse.com/"
                                  ],
                                  "expandedlicensing_standardLicenseHeader": "TestStandardLicenseHeader",
                                  "expandedlicensing_standardLicenseTemplate": "TestStandardLicenseTemplate",
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
                                  "type": "expandedlicensing_ListedLicense",
                                  "spdxId": "urn:ListedLicense:40f"
                                }
                                """;

        // Act
        var json = ToJson(listedLicense);

        // Assert
        Assert.Equal(expected, json);
    }
}