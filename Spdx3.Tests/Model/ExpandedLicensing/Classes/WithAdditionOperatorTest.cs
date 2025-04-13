using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

public class WithAdditionOperatorTest : BaseModelTest
{ 
    [Fact]
    public void BrandNew_WithAdditionOperator_SerializesProperly()
    {
        // Arrange
        var license = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "SomeLicense");
        var addition = new LicenseAdditionConcreteTestFixture(TestCatalog, TestCreationInfo, "SomeLicense");
        var withAdditionOperator = new WithAdditionOperator(TestCatalog, TestCreationInfo, license, addition);
        const string expected = """
                                {
                                  "expandedlicensing_subjectAddition": "urn:LicenseAdditionConcreteTestFixture:41c",
                                  "expandedlicensing_subjectExtendableLicense": "urn:LicenseConcreteTestFixture:40f",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "expandedlicensing_WithAdditionOperator",
                                  "spdxId": "urn:WithAdditionOperator:429"
                                }
                                """;

        // Act
        var json = ToJson(withAdditionOperator);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_ExtendableLicense_SerializesProperly()
    {
        // Arrange
        var license = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "SomeLicense");
        var addition = new LicenseAdditionConcreteTestFixture(TestCatalog, TestCreationInfo, "SomeLicense");
        var withAdditionOperator = new WithAdditionOperator(TestCatalog, TestCreationInfo, license, addition)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        withAdditionOperator.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        withAdditionOperator.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        withAdditionOperator.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        withAdditionOperator.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));


        const string expected = """
                                {
                                  "expandedlicensing_subjectAddition": "urn:LicenseAdditionConcreteTestFixture:41c",
                                  "expandedlicensing_subjectExtendableLicense": "urn:LicenseConcreteTestFixture:40f",
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "extension": [
                                    "urn:ExtensionConcreteTestFixture:436"
                                  ],
                                  "externalIdentifier": [
                                    "urn:ExternalIdentifier:443"
                                  ],
                                  "externalRef": [
                                    "urn:ExternalRef:450"
                                  ],
                                  "name": "TestName",
                                  "summary": "TestSummary",
                                  "verifiedUsing": [
                                    "urn:IntegrityMethodConcreteTestFixture:45d"
                                  ],
                                  "type": "expandedlicensing_WithAdditionOperator",
                                  "spdxId": "urn:WithAdditionOperator:429"
                                }
                                """;

        // Act
        var json = ToJson(withAdditionOperator);

        // Assert
        Assert.Equal(expected, json);
    }
}