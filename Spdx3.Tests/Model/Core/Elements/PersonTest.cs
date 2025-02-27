using Spdx3.Model.Core.Elements;
using Spdx3.Tests.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.Elements;

public class PersonTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Person_SerializesProperly()
    {
        // Arrange
        var pPerson = TestFactory.New<Person>(TestCreationInfo);
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
        var person = TestFactory.New<Person>(TestCreationInfo);
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