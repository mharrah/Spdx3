using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.NonElements;

public class ExternalMapTest : BaseModelTestClass
{
    [Fact]
    public void ExternalMap_Basics()
    {
        var externalMap = new ExternalMap(TestSpdxIdFactory, "some-external-spdx-id");

        // Assert
        Assert.NotNull(externalMap);
        Assert.IsType<ExternalMap>(externalMap);
        Assert.Equal("ExternalMap", externalMap.Type);
        Assert.Equal("urn:ExternalMap:402", externalMap.SpdxId);
    }

    [Fact]
    public void ExternalMap_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var externalMap = new ExternalMap(TestSpdxIdFactory, "some-external-spdx-id");

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
        var externalMap = new ExternalMap(TestSpdxIdFactory, "some-external-spdx-id");
        externalMap.ExternalSpdxId = "testref";
        externalMap.LocationHint = "Test Location Hint";
        externalMap.VerifiedUsing.Add(new TestIntegrityMethod(TestSpdxIdFactory));
        externalMap.DefiningArtifact = new TestArtifact(TestSpdxIdFactory, TestCreationInfo);

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
}