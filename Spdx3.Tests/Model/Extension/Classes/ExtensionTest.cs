namespace Spdx3.Tests.Model.Extension.Classes;

public class ExtensionTest : BaseModelTestClass
{
    [Fact]
    public void Extension_MinimalObject_Serializes()
    {
        // Arrange
        var extension = new TestExtension(TestCatalog);
        const string expected = """
                                {
                                  "type": "extension_TestExtension",
                                  "spdxId": "urn:TestExtension:40f"
                                }
                                """;

        // Act
        var json = ToJson(extension);

        // Assert
        Assert.Equal(expected, json);
    }
}