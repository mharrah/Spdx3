namespace Spdx3.Tests.Model.Extension.Classes;

public class ExtensionTest : BaseModelTestClass
{
    [Fact]
    public void Extension_MinimalObject_Serializes()
    {
        // Arrange
        var extension = new TestExtension(TestSpdxCatalog);
        const string expected = """
                                {
                                  "type": "extension_TestExtension",
                                  "spdxId": "urn:TestExtension:402"
                                }
                                """;

        // Act
        var json = extension.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}