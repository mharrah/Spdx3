using Spdx3.Model.Core.Elements;
using Spdx3.Tests.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.Elements;

public class IndividualElementTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_IndividualElement_SerializesProperly()
    {
        // Arrange
        var individualElement = TestFactory.New<IndividualElement>(TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "IndividualElement",
                                  "spdxId": "urn:IndividualElement:402"
                                }
                                """;

        // Act
        var json = individualElement.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_IndividualElement_SerializesProperly()
    {
        // Arrange
        var individualElement = TestFactory.New<IndividualElement>(TestCreationInfo);
        individualElement.Comment = "TestComment";
        individualElement.Description = "TestDescription";
        individualElement.Name = "TestName";

        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "IndividualElement",
                                  "spdxId": "urn:IndividualElement:402"
                                }
                                """;

        // Act
        var json = individualElement.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}