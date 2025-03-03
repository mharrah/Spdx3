using Spdx3.Model;
using Spdx3.Model.Software.Elements;

namespace Spdx3.Tests.Model.Software.Elements;

public class PackageTest : BaseModelTestClass
{
    [Fact]
    public void Package_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var package = new Package(TestSpdxIdFactory, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "software_Package",
                                  "spdxId": "urn:Package:402"
                                }
                                """;

        // Act
        var json = package.ToJson();
        
        // Assert
        Assert.Equal(expected, json);
    }
    
}