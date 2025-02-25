using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

public class ExternalMapTest : BaseSpdxClassTestClass
{
    [Fact]
    public void ExternalMap_Basics()
    {
        // Arrange
        var factory = new SpdxClassFactory();

        // Act
        var externalMap = factory.New<ExternalMap>();

        // Assert
        Assert.NotNull(externalMap);
        Assert.IsType<ExternalMap>(externalMap);
        Assert.Equal("ExternalMap", externalMap.Type);
        Assert.Equal("urn:ExternalMap:3f5", externalMap.SpdxId);
    }

    [Fact]
    public void ExternalMap_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var externalMap = TestFactory.New<ExternalMap>();

        var expected = """
                       {
                         "type": "ExternalMap",
                         "spdxId": "urn:ExternalMap:3f5"
                       }
                       """;

        // Act
        var json = externalMap.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void ExternalMap_FullyPopulated_SerializesAsExpected()
    {
        // Arrange
        var externalMap = TestFactory.New<ExternalMap>();
        externalMap.ExternalSpdxId = "testref";
        externalMap.LocationHint = "Test Location Hint";
        externalMap.VerifiedUsingRef.Add("testref");
        externalMap.DefiningArtifactRef = "testref";

        var expected = """
                       {
                         "definingArtifact": "testref",
                         "externalSpdxId": "testref",
                         "locationHint": "Test Location Hint",
                         "verifiedUsing": [
                           "testref"
                         ],
                         "type": "ExternalMap",
                         "spdxId": "urn:ExternalMap:3f5"
                       }
                       """;

        // Act
        var json = externalMap.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void ExternalMap_FailsValidation_WhenMissing_ExternalSpdxId()
    {
        // Arrange
        var externalMap = TestFactory.New<ExternalMap>();
        externalMap.ExternalSpdxId = null;
        externalMap.LocationHint = "Test Location Hint";
        externalMap.VerifiedUsingRef.Add("testref");
        externalMap.DefiningArtifactRef = "testref";

        //  Act
        var exception = Record.Exception(() => externalMap.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object ExternalMap, property ExternalSpdxId: Field is required", exception.Message);
    }

    [Fact]
    public void ExternalMap_FailsValidation_WhenEmpty_ExternalSpdxId()
    {
        // Arrange
        var externalMap = TestFactory.New<ExternalMap>();
        externalMap.ExternalSpdxId = "";
        externalMap.LocationHint = "Test Location Hint";
        externalMap.VerifiedUsingRef.Add("testref");
        externalMap.DefiningArtifactRef = "testref";

        //  Act
        var exception = Record.Exception(() => externalMap.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object ExternalMap, property ExternalSpdxId: Field is empty", exception.Message);
    }
}