using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Classes;

public class ExternalRefTest : BaseModelTest
{
    [Fact]
    public void ExternalRef_MinimalObject_Serializes()
    {
        // Arrange
        var externalRef = new ExternalRef(TestCatalog, ExternalRefType.license);
        const string expected = """
                                {
                                  "externalRefType": "license",
                                  "type": "ExternalRef",
                                  "spdxId": "urn:ExternalRef:40f"
                                }
                                """;

        // Act
        var json = ToJson(externalRef);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void ExternalRef_FullyPopulatedObject_Serializes()
    {
        // Arrange
        var externalRef = new ExternalRef(TestCatalog, ExternalRefType.license)
        {
            Comment = "Test comment",
            ContentType = "some sort of content"
        };
        externalRef.Locator.Add("locator 1");
        externalRef.Locator.Add("locator 2");
        const string expected = """
                                {
                                  "externalRefType": "license",
                                  "locator": [
                                    "locator 1",
                                    "locator 2"
                                  ],
                                  "contentType": "some sort of content",
                                  "comment": "Test comment",
                                  "type": "ExternalRef",
                                  "spdxId": "urn:ExternalRef:40f"
                                }
                                """;

        // Act
        var json = ToJson(externalRef);

        // Assert
        Assert.Equal(expected, json);
    }


    [Fact]
    public void ExternalRef_DeserializesAsExpected()
    {
        const string json = """
                            {
                              "externalRefType": "license",
                              "locator": [
                                "locator 1",
                                "locator 2"
                              ],
                              "contentType": "some sort of content",
                              "comment": "Test comment",
                              "type": "ExternalRef",
                              "spdxId": "urn:ExternalRef:40f"
                            }
                            """;

        var externalRef = FromJson<ExternalRef>(json);
        Assert.NotNull(externalRef);
        Assert.IsType<ExternalRef>(externalRef);
        Assert.Equal("ExternalRef", externalRef.Type);
        Assert.Equal(new Uri("urn:ExternalRef:40f"), externalRef.SpdxId);
        Assert.Equal("some sort of content", externalRef.ContentType);
        Assert.Equal(ExternalRefType.license, externalRef.ExternalRefType);
        Assert.Equal("Test comment", externalRef.Comment);
        Assert.Contains("locator 1", externalRef.Locator);
        Assert.Contains("locator 2", externalRef.Locator);
        Assert.Equal(2, externalRef.Locator.Count);
    }
}