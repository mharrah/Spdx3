using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

public class LicenseTest : BaseModelTest
{
    [Fact]
    public void BrandNew_License_SerializesProperly()
    {
        // Arrange
        var license = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "test license text");
        const string expected = """
                                {
                                  "simplelicensing_licenseText": "test license text",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "expandedlicensing_LicenseConcreteTestFixture",
                                  "spdxId": "urn:LicenseConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(license);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_License_SerializesProperly()
    {
        // Arrange
        var license = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "TestLicenseText")
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
        license.SeeAlso.Add(new Uri("https://something.com"));
        license.SeeAlso.Add(new Uri("https://somethingelse.com"));
        license.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        license.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        license.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        license.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));


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
                                  "type": "expandedlicensing_LicenseConcreteTestFixture",
                                  "spdxId": "urn:LicenseConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(license);

        // Assert
        Assert.Equal(expected, json);
    }
}