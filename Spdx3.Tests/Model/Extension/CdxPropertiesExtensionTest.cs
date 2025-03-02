using Spdx3.Model.Extension;

namespace Spdx3.Tests.Model.Extension;

public class CdxPropertiesExtensionTest : BaseModelTestClass
{
    [Fact]
    public void Extension_MinimalObject_Serializes()
    {
        // Arrange
        var extension = new CdxPropertiesExtension(TestSpdxIdFactory,
            [new CdxPropertyEntry(TestSpdxIdFactory, "TestPropertyName")]);
        extension.CdxProperty.Add(new CdxPropertyEntry(TestSpdxIdFactory, "TestPropertyName", "TestPropertyValue"));
        const string expected = """
                                {
                                  "cdxProperty": [
                                    "urn:CdxPropertyEntry:402",
                                    "urn:CdxPropertyEntry:41c"
                                  ],
                                  "type": "extension_CdxPropertiesExtension",
                                  "spdxId": "urn:CdxPropertiesExtension:40f"
                                }
                                """;


        // Act
        var json = extension.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}