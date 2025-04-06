using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Tests.Model.Extension.Classes;
using Spdx3.Tests.Model.SimpleLicensing.Classes;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

public class DisjunctiveLicenseSetTest : BaseModelTest
{
    [Fact]
    public void DisjunctiveLicense_OkIfAtLeastTwo_Members()
    {
        // Arrange
        var l1 = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "License 1");
        var l2 = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "License 2");
        var l3 = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "License 3");
        
        // Act
        var disjunctiveLicenseSet1 = new DisjunctiveLicenseSet(TestCatalog, TestCreationInfo, [l1, l2]);
        var disjunctiveLicenseSet2 = new DisjunctiveLicenseSet(TestCatalog, TestCreationInfo, [l1, l2, l3]);
        
        // Assert
        Assert.Equal(2, disjunctiveLicenseSet1.Member.Count);
        Assert.Equal(3, disjunctiveLicenseSet2.Member.Count);
    }

    [Fact]
    public void DisjunctiveLicense_FailsValidation_IfLessThanTwo_Members()
    {
        // Arrange
        var l1 = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "License 1");
        var l2 = new LicenseConcreteTestFixture(TestCatalog, TestCreationInfo, "License 2");
        var disjunctiveLicenseSet1 = new DisjunctiveLicenseSet(TestCatalog, TestCreationInfo, [l1, l2]);
        disjunctiveLicenseSet1.Member.Clear(); // This is the problem!
        
        // Act
        var exception = Record.Exception(() => disjunctiveLicenseSet1.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.IsType<Spdx3ValidationException>(exception);
        Assert.Contains("must have at least 2 licenses", exception.Message);
    }

    [Fact]
    public void BrandNew_DisjunctiveLicenseSet_SerializesProperly()
    {
        // Arrange
        var listedLicense = new ListedLicense(TestCatalog, TestCreationInfo, "listed license");
        var customLicense = new CustomLicense(TestCatalog, TestCreationInfo, "custom license");
        var disjunctiveLicenseSet = new DisjunctiveLicenseSet(TestCatalog, TestCreationInfo, [listedLicense, customLicense]);
        const string expected = """
                                {
                                  "expandedlicensing_member": [
                                    "urn:ListedLicense:40f",
                                    "urn:CustomLicense:41c"
                                  ],
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "expandedlicensing_DisjunctiveLicenseSet",
                                  "spdxId": "urn:DisjunctiveLicenseSet:429"
                                }
                                """;

        // Act
        var json = ToJson(disjunctiveLicenseSet);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_DisjunctiveLicenseSet_SerializesProperly()
    {
        // Arrange
        var listedLicense = new ListedLicense(TestCatalog, TestCreationInfo, "listed license");
        var customLicense = new CustomLicense(TestCatalog, TestCreationInfo, "custom license");
        var disjunctiveLicenseSet = new DisjunctiveLicenseSet(TestCatalog, TestCreationInfo, [listedLicense, customLicense])
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Summary = "TestSummary"
        };
        disjunctiveLicenseSet.Extension.Add(new ExtensionConcreteTestFixture(TestCatalog));
        disjunctiveLicenseSet.ExternalIdentifier.Add(
            new ExternalIdentifier(TestCatalog, ExternalIdentifierType.email, "example@example.com"));
        disjunctiveLicenseSet.ExternalRef.Add(new ExternalRef(TestCatalog, ExternalRefType.altDownloadLocation));
        disjunctiveLicenseSet.VerifiedUsing.Add(new IntegrityMethodConcreteTestFixture(TestCatalog));
        
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
                                  "type": "expandedlicensing_DisjunctiveLicenseSet",
                                  "spdxId": "urn:DisjunctiveLicenseSet:429"
                                }
                                """;

        // Act
        var json = ToJson(disjunctiveLicenseSet);

        // Assert
        Assert.Equal(expected, json);
    }

}