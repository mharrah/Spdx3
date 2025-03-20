using Spdx3.Model.Software.Classes;

namespace Spdx3.Tests.Model.Software.Classes;

public class PackageTest : BaseModelTestClass
{
    [Fact]
    public void Package_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var package = new Package(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "software_Package",
                                  "spdxId": "urn:Package:40f"
                                }
                                """;

        // Act
        var json = ToJson(package);

        // Assert
        Assert.Equal(expected, json);
    }
}