using Spdx3.Model.Extension;

namespace Spdx3.Tests.Model.Extension;

public class CdxPropertyEntryTest : BaseModelTestClass
{
    [Fact]
    public void Extension_MinimalObject_Serializes()
    {
        // Arrange
        var cdxProp = new CdxPropertyEntry(TestSpdxIdFactory, "TestPropertyName");
        const string expected = """
                                {
                                  "cdxPropName": "TestPropertyName",
                                  "type": "extension_CdxPropertyEntry",
                                  "spdxId": "urn:CdxPropertyEntry:402"
                                }
                                """;


        // Act
        var json = cdxProp.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
    
    [Fact]
    public void Extension_FullyPopulatedObject_Serializes()
    {
        // Arrange
        var cdxProp = new CdxPropertyEntry(TestSpdxIdFactory, "TestPropertyName", "test value");
        const string expected = """
                                {
                                  "cdxPropName": "TestPropertyName",
                                  "cdxPropValue": "test value",
                                  "type": "extension_CdxPropertyEntry",
                                  "spdxId": "urn:CdxPropertyEntry:402"
                                }
                                """;


        // Act
        var json = cdxProp.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}