using Spdx3.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Extension.Classes;

public class CdxPropertyEntryTest : BaseModelTestClass
{
    [Fact]
    public void Extension_MinimalObject_Serializes()
    {
        // Arrange
        var cdxProp = new CdxPropertyEntry(TestCatalog, "TestPropertyName");
        const string expected = """
                                {
                                  "extension_cdxPropName": "TestPropertyName",
                                  "type": "extension_CdxPropertyEntry",
                                  "spdxId": "urn:CdxPropertyEntry:40f"
                                }
                                """;


        // Act
        var json = ToJson(cdxProp);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void Extension_FullyPopulatedObject_Serializes()
    {
        // Arrange
        var cdxProp = new CdxPropertyEntry(TestCatalog, "TestPropertyName", "test value");
        const string expected = """
                                {
                                  "extension_cdxPropName": "TestPropertyName",
                                  "extension_cdxPropValue": "test value",
                                  "type": "extension_CdxPropertyEntry",
                                  "spdxId": "urn:CdxPropertyEntry:40f"
                                }
                                """;


        // Act
        var json = ToJson(cdxProp);

        // Assert
        Assert.Equal(expected, json);
    }
}