using Spdx3.Tests.Model.Core.Elements;
using Spdx3.Tests.Model.Core.NonElements;

namespace Spdx3.Tests.Model.SimpleLicensing;

public class AnyLicenseInfoTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_AnyLicenseInfo_SerializesProperly()
    {
        // Arrange
        var anyLicenseInfo = TestFactory.New<TestAnyLicenseInfo>(TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "simplelicensing_TestAnyLicenseInfo",
                                  "spdxId": "urn:TestAnyLicenseInfo:402"
                                }
                                """;

        // Act
        var json = anyLicenseInfo.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_AnyLicenseInfo_SerializesProperly()
    {
        // Arrange
        var anyLicenseInfo = TestFactory.New<TestAnyLicenseInfo>(TestCreationInfo);
        anyLicenseInfo.Comment = "TestComment";
        anyLicenseInfo.Description = "TestDescription";
        anyLicenseInfo.Name = "TestName";

        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "simplelicensing_TestAnyLicenseInfo",
                                  "spdxId": "urn:TestAnyLicenseInfo:402"
                                }
                                """;

        // Act
        var json = anyLicenseInfo.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}