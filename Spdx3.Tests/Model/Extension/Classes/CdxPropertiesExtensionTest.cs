using Spdx3.Model.Extension.Classes;

namespace Spdx3.Tests.Model.Extension.Classes;

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


    [Fact]
    public void Extension_Constructor_Throws_EmptyPropertiesList()
    {
        // Arrange


        // Act
        var expected = Record.Exception(() => new CdxPropertiesExtension(TestSpdxIdFactory, []));

        // Assert
        Assert.NotNull(expected);
    }

    [Fact]
    public void Extension_FailsValidation_When_NoProperties()
    {
        // Arrange
        var extension = new CdxPropertiesExtension(TestSpdxIdFactory,
            [new CdxPropertyEntry(TestSpdxIdFactory, "TestPropertyName")]);
        extension.CdxProperty.Clear();

        // Act
        var expected = Record.Exception(() => extension.Validate());

        // Assert
        Assert.NotNull(expected);
    }
}