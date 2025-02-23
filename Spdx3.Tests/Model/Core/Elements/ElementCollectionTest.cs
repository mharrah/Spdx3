using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Elements;

public class ElementCollectionTest : BaseElementTestClass
{
    [Fact]
    public void BrandNew_ElementCollection_SerializesProperly()
    {
        // Arrange
        var agent = TestFactory.New<TestElementCollection>(this.TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "TestElementCollection",
                                  "spdxId": "urn:TestElementCollection:402"
                                }
                                """;
        
        // Act
        var json = agent.ToJson();
        
        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_ElementCollection_SerializesProperly()
    {
        // Arrange
        var agent = TestFactory.New<TestElementCollection>(this.TestCreationInfo);
        agent.Comment = "TestComment";
        agent.Description = "TestDescription";
        agent.ElementRef.Add("testRef1");
        agent.ElementRef.Add("testRef2");
        agent.Name = "TestName";
        agent.RootElementRef.Add("testref");
        agent.ProfileConformance.Add(ProfileIdentifierType.security);
        
        const string expected = """
                                {
                                  "profileConformance": [
                                    "security"
                                  ],
                                  "rootElement": [
                                    "testref"
                                  ],
                                  "element": [
                                    "testRef1",
                                    "testRef2"
                                  ],
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "TestElementCollection",
                                  "spdxId": "urn:TestElementCollection:402"
                                }
                                """;
        
        // Act
        var json = agent.ToJson();
        
        // Assert
        Assert.Equal(expected, json);
    }
}