using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Elements;

public class RelationshipTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_Relationship_SerializesProperly()
    {
        // Arrange
        var from = new TestElement(TestSpdxIdFactory, TestCreationInfo);
        var to = new TestElement(TestSpdxIdFactory, TestCreationInfo);
        var relationship = new Relationship(TestSpdxIdFactory, TestCreationInfo, RelationshipType.describes,
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
        var from = new TestElement(TestSpdxIdFactory, TestCreationInfo);
        var to = new TestElement(TestSpdxIdFactory, TestCreationInfo);
        var relationship = new Relationship(TestSpdxIdFactory, TestCreationInfo, RelationshipType.describes,
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
        var from = new TestElement(TestSpdxIdFactory, TestCreationInfo);
        var relationship = new Relationship(TestSpdxIdFactory, TestCreationInfo, RelationshipType.describes,
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
        var from = new TestElement(TestSpdxIdFactory, TestCreationInfo);
        var to = new TestElement(TestSpdxIdFactory, TestCreationInfo);
        var relationship = new Relationship(TestSpdxIdFactory, TestCreationInfo, RelationshipType.describes,
            from, [to]);

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        relationship.From = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

        // Act
        var exception = Record.Exception(() => relationship.Validate());

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object Relationship, property From: Field is required", exception.Message);
    }
}