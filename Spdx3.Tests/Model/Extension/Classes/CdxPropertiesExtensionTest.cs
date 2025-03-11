using Spdx3.Model;
using Spdx3.Model.Extension.Classes;
using Xunit.Internal;

namespace Spdx3.Tests.Model.Extension.Classes;

public class CdxPropertiesExtensionTest : BaseModelTestClass
{
    [Fact]
    public void CdxPropertiesExtension_MinimalObject_Serializes()
    {
        // Arrange
        var cdxPropExt = new CdxPropertiesExtension(TestSpdxIdFactory,
            [new CdxPropertyEntry(TestSpdxIdFactory, "TestPropertyName")]);
        cdxPropExt.CdxProperty.Add(new CdxPropertyEntry(TestSpdxIdFactory, "TestPropertyName", "TestPropertyValue"));
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
        var json = cdxPropExt.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void CdxPropertiesExtension_Constructor_Throws_EmptyPropertiesList()
    {
        // Act
        var expected = Record.Exception(() => new CdxPropertiesExtension(TestSpdxIdFactory, []));

        // Assert
        Assert.NotNull(expected);
    }

    [Fact]
    public void CdxPropertiesExtension_FailsValidation_When_NoProperties()
    {
        // Arrange
        var cdxPropExt = new CdxPropertiesExtension(TestSpdxIdFactory,
            [new CdxPropertyEntry(TestSpdxIdFactory, "TestPropertyName")]);
        cdxPropExt.CdxProperty.Clear();

        // Act
        var expected = Record.Exception(() => cdxPropExt.Validate());

        // Assert
        Assert.NotNull(expected);
    }


    [Fact]
    public void CdxPropertiesExtension_Deserializes_Correctly()
    {
        const string json = """
                            {
                              "cdxProperty": [
                                "urn:CdxPropertyEntry:402",
                                "urn:CdxPropertyEntry:41c"
                              ],
                              "type": "extension_CdxPropertiesExtension",
                              "spdxId": "urn:CdxPropertiesExtension:40f"
                            }
                            """;

        var cdxPropExt = BaseSpdxClass.FromJson<CdxPropertiesExtension>(json);
        
        Assert.NotNull(cdxPropExt);
        Assert.Equal("urn:CdxPropertiesExtension:40f", cdxPropExt.SpdxId);
        Assert.Equal("extension_CdxPropertiesExtension", cdxPropExt.Type);
        var propList = cdxPropExt.CdxProperty.CastOrToList<CdxPropertyEntry>();
        Assert.Equal(2, propList.Count);
        Assert.Equal("urn:CdxPropertyEntry:402", propList[0].SpdxId);
        Assert.Equal("extension_CdxPropertyEntry", propList[0].Type);
        Assert.Equal("urn:CdxPropertyEntry:41c", propList[1].SpdxId);
        Assert.Equal("extension_CdxPropertyEntry", propList[1].Type);
    }
}