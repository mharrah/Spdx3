using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Classes;

public class ExternalRefTest : BaseModelTestClass
{
    [Fact]
    public void ExternalRef_MinimalObject_Serializes()
    {
        // Arrange
        var externalRef = new ExternalRef(TestSpdxIdFactory, ExternalRefType.license);
        const string expected = """
                                {
                                  "externalRefType": "license",
                                  "type": "ExternalRef",
                                  "spdxId": "urn:ExternalRef:402"
                                }
                                """;

        // Act
        var json = externalRef.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void ExternalRef_FullyPopulatedObject_Serializes()
    {
        // Arrange
        var externalRef = new ExternalRef(TestSpdxIdFactory, ExternalRefType.license)
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
                                  "spdxId": "urn:ExternalRef:402"
                                }
                                """;

        // Act
        var json = externalRef.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}