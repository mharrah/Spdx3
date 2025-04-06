using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;
using Spdx3.Tests.Model.SimpleLicensing.Classes;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

public class ConjunctiveLicenseSetTest : BaseModelTest
{
    [Fact]
    public void ConjunctiveLicense_OkIfAtLeastTwo_Members()
    {
        // Arrange
        var l1 = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "License 1");
        var l2 = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "License 2");
        var l3 = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "License 3");
        
        // Act
        var conjunctiveLicenseSet1 = new ConjunctiveLicenseSet(TestCatalog, TestCreationInfo, [l1, l2]);
        var conjunctiveLicenseSet2 = new ConjunctiveLicenseSet(TestCatalog, TestCreationInfo, [l1, l2, l3]);
        
        // Assert
        Assert.Equal(2, conjunctiveLicenseSet1.Member.Count);
        Assert.Equal(3, conjunctiveLicenseSet2.Member.Count);
    }

    [Fact]
    public void ConjunctiveLicense_FailsValidation_IfLessThanTwo_Members()
    {
        // Arrange
        var l1 = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "License 1");
        var l2 = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "License 2");
        var conjunctiveLicenseSet1 = new ConjunctiveLicenseSet(TestCatalog, TestCreationInfo, [l1, l2]);
        conjunctiveLicenseSet1.Member.Clear(); // This is the problem!
        
        // Act
        var exception = Record.Exception(() => conjunctiveLicenseSet1.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.IsType<Spdx3ValidationException>(exception);
        Assert.Contains("must have at least 2 licenses", exception.Message);
    }

    [Fact]
    public void BrandNew_ConjunctiveLicenseSet_SerializesProperly()
    {
        // Arrange
        var listedLicense = new ListedLicense(TestCatalog, TestCreationInfo, "listed license");
        var customLicense = new CustomLicense(TestCatalog, TestCreationInfo, "custom license");
        var conjunctiveLicenseSet = new ConjunctiveLicenseSet(TestCatalog, TestCreationInfo, [listedLicense, customLicense]);
        const string expected = """
                                {
                                  "expandedlicensing_member": [
                                    "urn:ListedLicense:40f",
                                    "urn:CustomLicense:41c"
                                  ],
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "expandedlicensing_ConjunctiveLicenseSet",
                                  "spdxId": "urn:ConjunctiveLicenseSet:429"
                                }
                                """;

        // Act
        var json = ToJson(conjunctiveLicenseSet);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_ConjunctiveLicenseSet_SerializesProperly()
    {
        // Arrange
        var listedLicense = new ListedLicense(TestCatalog, TestCreationInfo, "listed license");
        var customLicense = new CustomLicense(TestCatalog, TestCreationInfo, "custom license");
        var conjunctiveLicenseSet = new ConjunctiveLicenseSet(TestCatalog, TestCreationInfo, [listedLicense, customLicense])
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        conjunctiveLicenseSet.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        conjunctiveLicenseSet.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        conjunctiveLicenseSet.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        conjunctiveLicenseSet.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));
        
        const string expected = """
                                {
                                  "expandedlicensing_member": [
                                    "urn:ListedLicense:40f",
                                    "urn:CustomLicense:41c"
                                  ],
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
                                  "type": "expandedlicensing_ConjunctiveLicenseSet",
                                  "spdxId": "urn:ConjunctiveLicenseSet:429"
                                }
                                """;

        // Act
        var json = ToJson(conjunctiveLicenseSet);

        // Assert
        Assert.Equal(expected, json);
    }

}