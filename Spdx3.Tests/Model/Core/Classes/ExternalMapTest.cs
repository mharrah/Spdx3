using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class ExternalMapTest : BaseModelTestClass
{
    [Fact]
    public void ExternalMap_Basics()
    {
        var externalMap = new ExternalMap(TestCatalog, "some-external-spdx-id");

        // Assert
        Assert.NotNull(externalMap);
        Assert.IsType<ExternalMap>(externalMap);
        Assert.Equal("ExternalMap", externalMap.Type);
        Assert.Equal(new Uri("urn:ExternalMap:40f"), externalMap.SpdxId);
    }

    [Fact]
    public void ExternalMap_MinimallyPopulated_SerializesAsExpected()
    {
        // Arrange
        var externalMap = new ExternalMap(TestCatalog, "some-external-spdx-id");

        const string expected = """
                                {
                                  "externalSpdxId": "some-external-spdx-id",
                                  "type": "ExternalMap",
                                  "spdxId": "urn:ExternalMap:40f"
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
        var externalMap = new ExternalMap(TestCatalog, "some-external-spdx-id")
        {
            ExternalSpdxId = "testref",
            LocationHint = new Uri("https://somewhere"),
            DefiningArtifact = new TestArtifact(TestCatalog, TestCreationInfo)
        };
        externalMap.VerifiedUsing.Add(new TestIntegrityMethod(TestCatalog));


        const string expected = """
                                {
                                  "definingArtifact": "urn:TestArtifact:41c",
                                  "externalSpdxId": "testref",
                                  "locationHint": "https://somewhere/",
                                  "verifiedUsing": [
                                    "urn:TestIntegrityMethod:429"
                                  ],
                                  "type": "ExternalMap",
                                  "spdxId": "urn:ExternalMap:40f"
                                }
                                """;

        // Act
        var json = ToJson(externalMap);

        // Assert
        Assert.Equal(expected, json);
    }
}