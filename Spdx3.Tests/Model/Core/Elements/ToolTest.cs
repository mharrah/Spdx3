using Spdx3.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.Elements;

public class ToolTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Tool_SerializesProperly()
    {
        // Arrange
        var tool = new Tool(TestSpdxIdFactory, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Tool",
                                  "spdxId": "urn:Tool:402"
                                }
                                """;

        // Act
        var json = tool.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Tool_SerializesProperly()
    {
        // Arrange
        var tool = new Tool(TestSpdxIdFactory, TestCreationInfo)
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
                                  "spdxId": "urn:Tool:402"
                                }
                                """;

        // Act
        var json = tool.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}