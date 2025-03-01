using Spdx3.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Extension;

public class ExtensionTest : BaseModelTestClass
{
    [Fact]
    public void Extension_Constructor_Requires_SubclassOfExtension()
    {
        // Act
        var exception = Record.Exception(() => TestFactory.New<Spdx3.Model.Extension.Extension>());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("The requested type Extension is abstract and cannot be created.", exception.Message);
    }

    [Fact]
    public void Extension_MinimalObject_Serializes()
    {
        // Arrange
        var extension = TestFactory.New<TestExtension>();
        var expected = """
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