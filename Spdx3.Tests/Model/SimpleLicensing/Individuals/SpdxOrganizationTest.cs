using Spdx3.Model.Core.Individuals;

namespace Spdx3.Tests.Model.SimpleLicensing.Individuals;

public class SpdxOrganizationTest : BaseModelTestClass
{
    [Fact]
    public void SpdxOrganization_SpdxId_IsConstant()
    {
        // Arrange
        const string spdxId = "https://spdx.org/";
        
        // Act
        var spdxOrg = new SpdxOrganization(TestSpdxIdFactory, TestCreationInfo);
        
        // Assert
        Assert.Equal(spdxId, spdxOrg.SpdxId);
    }
    
}