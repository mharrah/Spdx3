using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

public class ExtendableLicenseTest : BaseModelTest
{
    [Fact]
    public void BrandNew_ExtendableLicense_SerializesProperly()
    {
        // Arrange
        var extendableLicense = new ExtendableLicenseConcreteTestFixture(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "expandedlicensing_ExtendableLicenseConcreteTestFixture",
                                  "spdxId": "urn:ExtendableLicenseConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(extendableLicense);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_ExtendableLicense_SerializesProperly()
    {
        // Arrange
        var anyLicense = new ExtendableLicenseConcreteTestFixture(TestCatalog, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        anyLicense.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        anyLicense.ExternalIdentifier.Add(new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email,
            "example@example.com"));
        anyLicense.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        anyLicense.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));

        const string expected = """
                                {
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
                                  "type": "expandedlicensing_ExtendableLicenseConcreteTestFixture",
                                  "spdxId": "urn:ExtendableLicenseConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(anyLicense);

        // Assert
        Assert.Equal(expected, json);
    }
}