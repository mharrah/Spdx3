using Spdx3.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.Elements;

public class PersonTest : BaseElementTestClass
{
    [Fact]
    public void BrandNew_Person_SerializesProperly()
    {
        // Arrange
        var pPerson = TestFactory.New<Person>(this.TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Person",
                                  "spdxId": "urn:Person:402"
                                }
                                """;
        
        // Act
        var json = pPerson.ToJson();
        
        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Person_SerializesProperly()
    {
        // Arrange
        var person = TestFactory.New<Person>(this.TestCreationInfo);
        person.Comment = "TestComment";
        person.Description = "TestDescription";
        person.Name = "TestName";
        
        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "Person",
                                  "spdxId": "urn:Person:402"
                                }
                                """;
        
        // Act
        var json = person.ToJson();
        
        // Assert
        Assert.Equal(expected, json);
    }
}