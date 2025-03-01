using Spdx3.Model.Extension;

namespace Spdx3.Tests.Model.Extension;

public class CdxPropertiesExtensionTest : BaseModelTestClass
{
    [Fact]
    public void Extension_MinimalObject_Serializes()
    {
        // Arrange
        var extension = TestFactory.New<CdxPropertiesExtension>();
        extension.CdxProperty.Add(TestFactory.New<CdxPropertyEntry>());
        var expected = """
                       {
                         "cdxProperty": [
                           "urn:CdxPropertyEntry:40f"
                         ],
                         "type": "extension_CdxPropertiesExtension",
                         "spdxId": "urn:CdxPropertiesExtension:402"
                       }
                       """;


        // Act
        var json = extension.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}