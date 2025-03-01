using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.Elements;

public class RelationshipTest : BaseModelTestClass
{
    [Fact]
    public void RelationShip_Requires_Correct_Factory_Method()
    {
        // Arrange
        const string expected =
            "Creating instances of Relationship requires using the " +
            "New(CreationInfo creationInfo, RelationshipType relationshipType, Element from, List<Element> to) form";

        // Act
        var exception = Record.Exception(() => TestFactory.New<Relationship>());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal(expected, exception.Message);
    }

    [Fact]
    public void BrandNew_Relationship_SerializesProperly()
    {
        // Arrange
        var from = TestFactory.New<TestElement>(TestCreationInfo);
        var to = TestFactory.New<TestElement>(TestCreationInfo);
        var relationship = TestFactory.New<Relationship>(TestCreationInfo, RelationshipType.describes,
            from, [to]);
        const string expected = """
                                {
                                  "from": "urn:TestElement:402",
                                  "to": [
                                    "urn:TestElement:40f"
                                  ],
                                  "relationshipType": "describes",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Relationship",
                                  "spdxId": "urn:Relationship:41c"
                                }
                                """;

        // Act
        var json = relationship.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Relationship_SerializesProperly()
    {
        // Arrange
        var from = TestFactory.New<TestElement>(TestCreationInfo);
        var to = TestFactory.New<TestElement>(TestCreationInfo);
        var relationship = TestFactory.New<Relationship>(TestCreationInfo, RelationshipType.describes,
            from, [to]);
        relationship.Comment = "TestComment";
        relationship.Description = "TestDescription";
        relationship.Name = "TestName";
        relationship.Completeness = RelationshipCompleteness.complete;
        relationship.StartTime = PredictableDateTime;
        relationship.EndTime = PredictableDateTime;

        const string expected = """
                                {
                                  "from": "urn:TestElement:402",
                                  "to": [
                                    "urn:TestElement:40f"
                                  ],
                                  "relationshipType": "describes",
                                  "completeness": "complete",
                                  "startTime": "2025-02-22T01:23:45Z",
                                  "endTime": "2025-02-22T01:23:45Z",
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "Relationship",
                                  "spdxId": "urn:Relationship:41c"
                                }
                                """;

        // Act
        var json = relationship.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void Relationship_Requires_AtLeastOne_To()
    {
        // Arrange
        var from = TestFactory.New<TestElement>(TestCreationInfo);
        var relationship = TestFactory.New<Relationship>(TestCreationInfo, RelationshipType.describes,
            from, []); // Note that the to array is empty

        // Act
        var exception = Record.Exception(() => relationship.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object Relationship, property To: Cannot be empty", exception.Message);
    }

    [Fact]
    public void Relationship_Requires_From()
    {
        // Arrange
        var from = TestFactory.New<TestElement>(TestCreationInfo);
        var to = TestFactory.New<TestElement>(TestCreationInfo);
        var relationship = TestFactory.New<Relationship>(TestCreationInfo, RelationshipType.describes,
            from, [to]);

        relationship.From = null;

        // Act
        var exception = Record.Exception(() => relationship.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object Relationship, property From: Field is required", exception.Message);
    }
}