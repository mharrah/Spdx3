using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class AgentTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Agent_SerializesProperly()
    {
        // Arrange
        var agent = new Agent(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Agent",
                                  "spdxId": "urn:Agent:40f"
                                }
                                """;

        // Act
        var json = ToJson(agent);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Agent_SerializesProperly()
    {
        // Arrange
        var agent = new Agent(TestCatalog, TestCreationInfo)
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
                                  "type": "Agent",
                                  "spdxId": "urn:Agent:40f"
                                }
                                """;

        // Act
        var json = ToJson(agent);

        // Assert
        Assert.Equal(expected, json);
    }
}