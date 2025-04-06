using Spdx3.Model.ExpandedLicensing.Classes;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

public class IndividualLicensingInfoTest : BaseModelTest
{
    [Fact]
    public void NoAssertionLicense_SpdxId_IsConstant()
    {
        // Arrange
        var spdxId = new Uri("urn:IndividualLicensingInfo:40f");

        // Act
        var spdxOrg = new IndividualLicensingInfo(TestCatalog, TestCreationInfo);

        // Assert
        Assert.Equal(spdxId, spdxOrg.SpdxId);
    }
}