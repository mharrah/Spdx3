using Spdx3.Model.Core.Classes;

namespace Spdx3.Tests.Model.Core.Classes;

public class PersonTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Person_SerializesProperly()
    {
        // Arrange
        var pPerson = new Person(TestCatalog, TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Person",
                                  "spdxId": "urn:Person:40f"
                                }
                                """;

        // Act
        var json = ToJson(pPerson);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Person_SerializesProperly()
    {
        // Arrange
        var person = new Person(TestCatalog, TestCreationInfo)
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
                                  "type": "Person",
                                  "spdxId": "urn:Person:40f"
                                }
                                """;

        // Act
        var json = ToJson(person);

        // Assert
        Assert.Equal(expected, json);
    }
}