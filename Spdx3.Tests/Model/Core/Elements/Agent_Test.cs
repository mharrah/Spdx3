using Spdx3.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.Elements;

public class AgentTest : BaseElementTestClass
{
    [Fact]
    public void Agent_HasCorrectType()
    {
        var agent = new Agent(TestIdFactory, TestCreationInfo);
        Assert.NotNull(agent);
        Assert.Equal("Agent", agent.Type);
    }

    [Fact]
    public void Agent_ConstructorGeneratesId()
    {
        var agent = new Agent(TestIdFactory, TestCreationInfo);
        Assert.NotNull(agent);
        Assert.Equal("urn:Agent:testRef", agent.SpdxId);
    }


    [Fact]
    public void Agent_IsSerializableToJson()
    {
        var agent = new Agent(TestIdFactory, TestCreationInfo);
        agent.Comment = "Test Comment";
        agent.Summary = "Test Summary";
        agent.Description = "Test Description";
        var json = agent.ToJson();
        var expected = """
                       {
                         "comment": "Test Comment",
                         "creationInfo": "urn:CreationInfo:testRef",
                         "description": "Test Description",
                         "summary": "Test Summary",
                         "type": "Agent",
                         "spdxId": "urn:Agent:testRef"
                       }
                       """;
        Assert.Equal(expected, json);
    }
}