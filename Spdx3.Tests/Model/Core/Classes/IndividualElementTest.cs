using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class IndividualElementTest : BaseModelTest
{
    [Fact]
    public void BrandNew_IndividualElement_SerializesProperly()
    {
        // Arrange
        var individualElement = new IndividualElement(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "IndividualElement",
                                  "spdxId": "urn:IndividualElement:40f"
                                }
                                """;

        // Act
        var json = ToJson(individualElement);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_IndividualElement_SerializesProperly()
    {
        // Arrange
        var individualElement = new IndividualElement(TestCatalog, TestCreationInfo)
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName"
        };

        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "IndividualElement",
                                  "spdxId": "urn:IndividualElement:40f"
                                }
                                """;

        // Act
        var json = ToJson(individualElement);

        // Assert
        Assert.Equal(expected, json);
    }
}