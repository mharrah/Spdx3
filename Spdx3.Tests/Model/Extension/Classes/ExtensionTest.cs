namespace Spdx3.Tests.Model.Extension.Classes;

public class ExtensionTest : BaseModelTest
{
    [Fact]
    public void Extension_MinimalObject_Serializes()
    {
        // Arrange
        var extension = new ExtensionConcreteTestFixture(TestCatalog);
        const string expected = """
                                {
                                  "type": "extension_ExtensionConcreteTestFixture",
                                  "spdxId": "urn:ExtensionConcreteTestFixture:40f"
                                }
                                """;

        // Act
        var json = ToJson(extension);

        // Assert
        Assert.Equal(expected, json);
    }
}