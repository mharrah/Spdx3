using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class ToolTest : BaseModelTest
{
    [Fact]
    public void BrandNew_Tool_SerializesProperly()
    {
        // Arrange
        var tool = new Tool(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Tool",
                                  "spdxId": "urn:Tool:40f"
                                }
                                """;

        // Act
        var json = ToJson(tool);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Tool_SerializesProperly()
    {
        // Arrange
        var tool = new Tool(TestCatalog, TestCreationInfo)
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
                                  "type": "Tool",
                                  "spdxId": "urn:Tool:40f"
                                }
                                """;

        // Act
        var json = ToJson(tool);

        // Assert
        Assert.Equal(expected, json);
    }
}