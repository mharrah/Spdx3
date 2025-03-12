using Spdx3.Model.Software.Classes;
using Spdx3.Model.Software.Enums;

namespace Spdx3.Tests.Model.Software.Classes;

public class ContentIdentifierTest : BaseModelTestClass
{
    [Fact]
    public void ContentIdentifier_MinimalObject_ShouldSerialize()
    {
        // Arrange
        var contentIdentifier =
            new ContentIdentifier(TestSpdxCatalog, ContentIdentifierType.gitoid, "some gitoid value");
        const string expected = """
                                {
                                  "contentIdentifierType": "gitoid",
                                  "contentIdentifierValue": "some gitoid value",
                                  "type": "software_ContentIdentifier",
                                  "spdxId": "urn:ContentIdentifier:402"
                                }
                                """;

        // Act
        var json = ToJson(contentIdentifier);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void ContentIdentifier_FullyPopulated_ShouldSerialize()
    {
        // Arrange
        var contentIdentifier =
            new ContentIdentifier(TestSpdxCatalog, ContentIdentifierType.gitoid, "some gitoid value");
        contentIdentifier.Comment = "test comment";
        const string expected = """
                                {
                                  "contentIdentifierType": "gitoid",
                                  "contentIdentifierValue": "some gitoid value",
                                  "comment": "test comment",
                                  "type": "software_ContentIdentifier",
                                  "spdxId": "urn:ContentIdentifier:402"
                                }
                                """;

        // Act
        var json = ToJson(contentIdentifier);

        // Assert
        Assert.Equal(expected, json);
    }
}