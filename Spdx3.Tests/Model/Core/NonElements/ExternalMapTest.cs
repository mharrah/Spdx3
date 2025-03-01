using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.Elements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

public class ExternalMapTest : BaseModelTestClass
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
        var externalMap = TestFactory.New<ExternalMap>("some-external-spdx-id");

        const string expected = """
                                {
                                  "externalSpdxId": "some-external-spdx-id",
                                  "type": "ExternalMap",
                                  "spdxId": "urn:ExternalMap:402"
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
        externalMap.VerifiedUsing.Add(TestFactory.New<TestIntegrityMethod>());
        externalMap.DefiningArtifact = TestFactory.New<TestArtifact>(TestCreationInfo);

        const string expected = """
                                {
                                  "definingArtifact": "urn:TestArtifact:41c",
                                  "externalSpdxId": "testref",
                                  "locationHint": "Test Location Hint",
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:40f"
                                  ],
                                  "type": "ExternalMap",
                                  "spdxId": "urn:ExternalMap:402"
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
        externalMap.VerifiedUsing.Add(TestFactory.New<TestIntegrityMethod>());
        externalMap.DefiningArtifact = TestFactory.New<TestArtifact>(TestCreationInfo);

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
        externalMap.VerifiedUsing.Add(TestFactory.New<TestIntegrityMethod>());
        externalMap.DefiningArtifact = TestFactory.New<TestArtifact>(TestCreationInfo);

        //  Act
        var exception = Record.Exception(() => externalMap.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object ExternalMap, property ExternalSpdxId: Field is empty", exception.Message);
    }
}