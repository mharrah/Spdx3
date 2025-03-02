using Spdx3.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.Elements;

public class SoftwareAgentTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_SoftwareAgent_SerializesProperly()
    {
        // Arrange
        var agent = new SoftwareAgent(TestSpdxIdFactory, TestCreationInfo);
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
        var agent = new SoftwareAgent(TestSpdxIdFactory, TestCreationInfo)
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