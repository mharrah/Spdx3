using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class ExternalMapTest : BaseModelTestClass
{
    [Fact]
    public void ExternalMap_Basics()
    {
        var externalMap = new ExternalMap(TestSpdxCatalog, "some-external-spdx-id");

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
        var externalMap = new ExternalMap(TestSpdxCatalog, "some-external-spdx-id");

        const string expected = """
                                {
                                  "externalSpdxId": "some-external-spdx-id",
                                  "type": "ExternalMap",
                                  "spdxId": "urn:ExternalMap:402"
                                }
                                """;

        // Act
        var json = ToJson(externalMap);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void ExternalMap_FullyPopulated_SerializesAsExpected()
    {
        // Arrange
        var externalMap = new ExternalMap(TestSpdxCatalog, "some-external-spdx-id")
        {
            ExternalSpdxId = "testref",
            LocationHint = "Test Location Hint",
            DefiningArtifact = new TestArtifact(TestSpdxCatalog, TestCreationInfo)
        };
        externalMap.VerifiedUsing.Add(new TestIntegrityMethod(TestSpdxCatalog));


        const string expected = """
                                {
                                  "definingArtifact": "urn:TestArtifact:40f",
                                  "externalSpdxId": "testref",
                                  "locationHint": "Test Location Hint",
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:41c"
                                  ],
                                  "type": "ExternalMap",
                                  "spdxId": "urn:ExternalMap:402"
                                }
                                """;

        // Act
        var json = ToJson(externalMap);

        // Assert
        Assert.Equal(expected, json);
    }
}