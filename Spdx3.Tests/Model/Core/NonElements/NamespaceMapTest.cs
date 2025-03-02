using Spdx3.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.NonElements;

public class NamespaceMapTest : BaseModelTestClass
{
    [Fact]
    public void NamespaceMap_Basics()
    {
        var namespaceMap = new NamespaceMap(TestSpdxIdFactory, "TestPrefix", "TestNamespace");

        // Assert
        Assert.NotNull(namespaceMap);
        Assert.IsType<NamespaceMap>(namespaceMap);
        Assert.Equal("NamespaceMap", namespaceMap.Type);
        Assert.Equal("urn:NamespaceMap:402", namespaceMap.SpdxId);
    }

    [Fact]
    public void NamespaceMap_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var namespaceMap = new NamespaceMap(TestSpdxIdFactory, "TestPrefix", "TestNamespace");
        namespaceMap.Prefix = "TestPrefix";
        namespaceMap.Namespace = "TestNamespace";
        const string expected = """
                                {
                                  "prefix": "TestPrefix",
                                  "namespace": "TestNamespace",
                                  "type": "NamespaceMap",
                                  "spdxId": "urn:NamespaceMap:402"
                                }
                                """;

        // Act
        var json = namespaceMap.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void NamespaceMap_FailsValidation_WhenMissing_Prefix()
    {
        // Arrange
        var namespaceMap = new NamespaceMap(TestSpdxIdFactory, "TestPrefix", "TestNamespace");
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        namespaceMap.Prefix = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        namespaceMap.Namespace = "TestNamespace";

        //  Act
        var exception = Record.Exception(() => namespaceMap.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object NamespaceMap, property Prefix: Field is required", exception.Message);
    }

    [Fact]
    public void NamespaceMap_FailsValidation_WhenEmpty_Prefix()
    {
        // Arrange
        var namespaceMap = new NamespaceMap(TestSpdxIdFactory, "TestPrefix", "TestNamespace");
        namespaceMap.Prefix = "";
        namespaceMap.Namespace = "TestNamespace";

        //  Act
        var exception = Record.Exception(() => namespaceMap.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object NamespaceMap, property Prefix: Field is empty", exception.Message);
    }

    [Fact]
    public void NamespaceMap_FailsValidation_WhenMissing_Namespace()
    {
        // Arrange
        var namespaceMap = new NamespaceMap(TestSpdxIdFactory, "TestPrefix", "TestNamespace");
        namespaceMap.Prefix = "TestPrefix";
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        namespaceMap.Namespace = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

        //  Act
        var exception = Record.Exception(() => namespaceMap.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object NamespaceMap, property Namespace: Field is required", exception.Message);
    }

    [Fact]
    public void NamespaceMap_FailsValidation_WhenEmpty_Namespace()
    {
        // Arrange
        var namespaceMap = new NamespaceMap(TestSpdxIdFactory, "TestPrefix", "TestNamespace");
        namespaceMap.Prefix = "TestPrefix";
        namespaceMap.Namespace = "";

        //  Act
        var exception = Record.Exception(() => namespaceMap.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object NamespaceMap, property Namespace: Field is empty", exception.Message);
    }
}