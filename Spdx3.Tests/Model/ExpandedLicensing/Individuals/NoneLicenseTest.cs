using Spdx3.Model.ExpandedLicensing.Individuals;

namespace Spdx3.Tests.Model.ExpandedLicensing.Individuals;

public class NoneLicenseTest : BaseModelTest
{
    [Fact]
    public void NoneLicense_SpdxId_IsConstant()
    {
        // Arrange
        var spdxId = new Uri("https://spdx.org/rdf/3.0.1/terms/Licensing/None");

        // Act
        var spdxOrg = new NoneLicense(TestCatalog, TestCreationInfo);

        // Assert
        Assert.Equal(spdxId, spdxOrg.SpdxId);
    }
}