using Spdx3.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.Elements;

public class AgentTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Agent_SerializesProperly()
    {
        // Arrange
        var agent = TestFactory.New<Agent>(TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Agent",
                                  "spdxId": "urn:Agent:402"
                                }
                                """;

        // Act
        var json = agent.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Agent_SerializesProperly()
    {
        // Arrange
        var agent = TestFactory.New<Agent>(TestCreationInfo);
        agent.Comment = "TestComment";
        agent.Description = "TestDescription";
        agent.Name = "TestName";

        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "Agent",
                                  "spdxId": "urn:Agent:402"
                                }
                                """;

        // Act
        var json = agent.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}