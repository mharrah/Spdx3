using Spdx3.Model.Extension.Classes;
using Xunit.Internal;

namespace Spdx3.Tests.Model.Extension.Classes;

public class CdxPropertiesExtensionTest : BaseModelTestClass
{
    [Fact]
    public void CdxPropertiesExtension_MinimalObject_Serializes()
    {
        // Arrange
        var cdxPropExt = new CdxPropertiesExtension(TestCatalog,
            [new CdxPropertyEntry(TestCatalog, "TestPropertyName")]);
        cdxPropExt.CdxProperty.Add(new CdxPropertyEntry(TestCatalog, "TestPropertyName", "TestPropertyValue"));
        const string expected = """
                                {
                                  "extension_cdxProperty": [
                                    "urn:CdxPropertyEntry:40f",
                                    "urn:CdxPropertyEntry:429"
                                  ],
                                  "type": "extension_CdxPropertiesExtension",
                                  "spdxId": "urn:CdxPropertiesExtension:41c"
                                }
                                """;


        // Act
        var json = ToJson(cdxPropExt);

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void CdxPropertiesExtension_Constructor_Throws_EmptyPropertiesList()
    {
        // Act
        var expected = Record.Exception(() => new CdxPropertiesExtension(TestCatalog, []));

        // Assert
        Assert.NotNull(expected);
    }

    [Fact]
    public void CdxPropertiesExtension_FailsValidation_When_NoProperties()
    {
        // Arrange
        var cdxPropExt = new CdxPropertiesExtension(TestCatalog,
            [new CdxPropertyEntry(TestCatalog, "TestPropertyName")]);
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
                              "extension_cdxProperty": [
                                "urn:CdxPropertyEntry:402",
                                "urn:CdxPropertyEntry:41c"
                              ],
                              "type": "extension_CdxPropertiesExtension",
                              "spdxId": "urn:CdxPropertiesExtension:40f"
                            }
                            """;

        var cdxPropExt = FromJson<CdxPropertiesExtension>(json);

        Assert.NotNull(cdxPropExt);
        Assert.Equal(new Uri("urn:CdxPropertiesExtension:40f"), cdxPropExt.SpdxId);
        Assert.Equal("extension_CdxPropertiesExtension", cdxPropExt.Type);
        var propList = cdxPropExt.CdxProperty.CastOrToList();
        Assert.Equal(2, propList.Count);
        Assert.Equal(new Uri("urn:CdxPropertyEntry:402"), propList[0].SpdxId);
        Assert.Equal("extension_CdxPropertyEntry", propList[0].Type);
        Assert.Equal(new Uri("urn:CdxPropertyEntry:41c"), propList[1].SpdxId);
        Assert.Equal("extension_CdxPropertyEntry", propList[1].Type);
    }
}