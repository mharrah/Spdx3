using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class SoftwareAgentTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_SoftwareAgent_SerializesProperly()
    {
        // Arrange
        var agent = new SoftwareAgent(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "SoftwareAgent",
                                  "spdxId": "urn:SoftwareAgent:40f"
                                }
                                """;

        // Act
        var json = ToJson(agent);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_SoftwareAgent_SerializesProperly()
    {
        // Arrange
        var agent = new SoftwareAgent(TestCatalog, TestCreationInfo)
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
                                  "spdxId": "urn:SoftwareAgent:40f"
                                }
                                """;

        // Act
        var json = ToJson(agent);

        // Assert
        Assert.Equal(expected, json);
    }
}