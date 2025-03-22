using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class NamespaceMapTest : BaseModelTestClass
{
    [Fact]
    public void NamespaceMap_Basics()
    {
        var namespaceMap = new NamespaceMap(TestCatalog, "TestPrefix", new Uri("urn:TestNamespace"));

        // Assert
        Assert.NotNull(namespaceMap);
        Assert.IsType<NamespaceMap>(namespaceMap);
        Assert.Equal("NamespaceMap", namespaceMap.Type);
        Assert.Equal(new Uri("urn:NamespaceMap:40f"), namespaceMap.SpdxId);
    }

    [Fact]
    public void NamespaceMap_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var namespaceMap = new NamespaceMap(TestCatalog, "TestPrefix", new Uri("urn:TestNamespace"))
        {
            Prefix = "TestPrefix",
            Namespace = new Uri("urn:TestNamespace")
        };
        const string expected = """
                                {
                                  "prefix": "TestPrefix",
                                  "namespace": "urn:TestNamespace",
                                  "type": "NamespaceMap",
                                  "spdxId": "urn:NamespaceMap:40f"
                                }
                                """;

        // Act
        var json = ToJson(namespaceMap);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void NamespaceMap_FailsValidation_WhenMissing_Prefix()
    {
        // Arrange
        var namespaceMap = new NamespaceMap(TestCatalog, "TestPrefix", new Uri("urn:TestNamespace"));
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        namespaceMap.Prefix = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        namespaceMap.Namespace = new Uri("urn:TestNamespace");

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
        var namespaceMap = new NamespaceMap(TestCatalog, "TestPrefix", new Uri("urn:TestNamespace"))
        {
            Prefix = "",
            Namespace = new Uri("urn:TestNamespace")
        };

        //  Act
        var exception = Record.Exception(() => namespaceMap.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object NamespaceMap, property Prefix: String field is empty", exception.Message);
    }

    [Fact]
    public void NamespaceMap_FailsValidation_WhenMissing_Namespace()
    {
        // Arrange
        var namespaceMap = new NamespaceMap(TestCatalog, "TestPrefix", new Uri("urn:TestNamespace"))
        {
            Prefix = "TestPrefix"
        };
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        namespaceMap.Namespace = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

        //  Act
        var exception = Record.Exception(() => namespaceMap.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object NamespaceMap, property Namespace: Field is required", exception.Message);
    }

}