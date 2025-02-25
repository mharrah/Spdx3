using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

public class NamespaceMapTest : BaseSpdxClassTestClass
{
    [Fact]
    public void NamespaceMap_Basics()
    {
        // Arrange
        var factory = new SpdxClassFactory();

        // Act
        var namespaceMap = factory.New<NamespaceMap>();

        // Assert
        Assert.NotNull(namespaceMap);
        Assert.IsType<NamespaceMap>(namespaceMap);
        Assert.Equal("NamespaceMap", namespaceMap.Type);
        Assert.Equal("urn:NamespaceMap:3f5", namespaceMap.SpdxId);
    }

    [Fact]
    public void NamespaceMap_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var namespaceMap = TestFactory.New<NamespaceMap>();
        namespaceMap.Prefix = "TestPrefix";
        namespaceMap.Namespace = "TestNamespace";
        const string expected = """
                                {
                                  "prefix": "TestPrefix",
                                  "namespace": "TestNamespace",
                                  "type": "NamespaceMap",
                                  "spdxId": "urn:NamespaceMap:3f5"
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
        var namespaceMap = TestFactory.New<NamespaceMap>();
        namespaceMap.Prefix = null;
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
        var namespaceMap = TestFactory.New<NamespaceMap>();
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
        var namespaceMap = TestFactory.New<NamespaceMap>();
        namespaceMap.Prefix = "TestPrefix";
        namespaceMap.Namespace = null;

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
        var namespaceMap = TestFactory.New<NamespaceMap>();
        namespaceMap.Prefix = "TestPrefix";
        namespaceMap.Namespace = "";

        //  Act
        var exception = Record.Exception(() => namespaceMap.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object NamespaceMap, property Namespace: Field is empty", exception.Message);
    }
}