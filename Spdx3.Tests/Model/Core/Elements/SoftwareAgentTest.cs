using Spdx3.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.Elements;

public class SoftwareAgentTest : BaseElementTestClass
{
    [Fact]
    public void BrandNew_SoftwareAgent_SerializesProperly()
    {
        // Arrange
        var agent = TestFactory.New<SoftwareAgent>(TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "SoftwareAgent",
                                  "spdxId": "urn:SoftwareAgent:402"
                                }
                                """;

        // Act
        var json = agent.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_SoftwareAgent_SerializesProperly()
    {
        // Arrange
        var agent = TestFactory.New<SoftwareAgent>(TestCreationInfo);
        agent.Comment = "TestComment";
        agent.Description = "TestDescription";
        agent.Name = "TestName";

        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "SoftwareAgent",
                                  "spdxId": "urn:SoftwareAgent:402"
                                }
                                """;

        // Act
        var json = agent.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}