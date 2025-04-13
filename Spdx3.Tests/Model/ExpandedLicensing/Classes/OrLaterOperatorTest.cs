using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

public class OrLaterOperatorTest : BaseModelTest
{
    [Fact]
    public void BrandNew_OrLaterOperator_SerializesProperly()
    {
        // Arrange
        var license = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "SomeLicense");
        var orLaterOperator = new OrLaterOperator(TestCatalog, TestCreationInfo, license);
        const string expected = """
                                {
                                  "expandedlicensing_subjectLicense": "urn:LicenseConcreteTestFixture:40f",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "expandedlicensing_OrLaterOperator",
                                  "spdxId": "urn:OrLaterOperator:41c"
                                }
                                """;

        // Act
        var json = ToJson(orLaterOperator);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_ExtendableLicense_SerializesProperly()
    {
        // Arrange
        var license = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "SomeLicense");
        var orLaterOperator = new OrLaterOperator(TestCatalog, TestCreationInfo, license)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        orLaterOperator.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        orLaterOperator.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        orLaterOperator.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        orLaterOperator.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));


        const string expected = """
                                {
                                  "expandedlicensing_subjectLicense": "urn:LicenseConcreteTestFixture:40f",
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "extension": [
                                    "urn:ExtensionConcreteTestFixture:429"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:436"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:443"
                                  ],
                                  "name": "TestName",
                                  "summary": "TestSummary",
                                  "verifiedUsing": [
                                    "urn:IntegrityMethodConcreteTestFixture:450"
                                  ],
                                  "type": "expandedlicensing_OrLaterOperator",
                                  "spdxId": "urn:OrLaterOperator:41c"
                                }
                                """;

        // Act
        var json = ToJson(orLaterOperator);

        // Assert
        Assert.Equal(expected, json);
    }
}