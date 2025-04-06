using Spdx3.Model.ExpandedLicensing.Individuals;

namespace Spdx3.Tests.Model.ExpandedLicensing.Individuals;

public class NoAssertionLicenseTest : BaseModelTest
{
    [Fact]
    public void NoAssertionLicense_SpdxId_IsConstant()
    {
        // Arrange
        var spdxId = new Uri("https://spdx.org/rdf/3.0.1/terms/Licensing/NoAssertion");

        // Act
        var spdxOrg = new NoAssertionLicense(TestCatalog, TestCreationInfo);

        // Assert
        Assert.Equal(spdxId, spdxOrg.SpdxId);
    }
}