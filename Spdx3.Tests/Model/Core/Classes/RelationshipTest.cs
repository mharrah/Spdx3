using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Classes;

public class RelationshipTest : BaseModelTest
{
    [Fact]
    public void BrandNew_Relationship_SerializesProperly()
    {
        // Arrange
        var from = new ElementConcreteTestFixture(TestCatalog, TestCreationInfo);
        var to = new ElementConcreteTestFixture(TestCatalog, TestCreationInfo);
        var relationship = new Relationship(TestCatalog, TestCreationInfo, RelationshipType.describes,
            from, [to]);
        const string expected = """
                                {
                                  "from": "urn:ElementConcreteTestFixture:40f",
                                  "relationshipType": "describes",
                                  "to": [
                                    "urn:ElementConcreteTestFixture:41c"
                                  ],
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "Relationship",
                                  "spdxId": "urn:Relationship:429"
                                }
                                """;

        // Act
        var json = ToJson(relationship);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Relationship_SerializesProperly()
    {
        // Arrange
        var from = new ElementConcreteTestFixture(TestCatalog, TestCreationInfo);
        var to = new ElementConcreteTestFixture(TestCatalog, TestCreationInfo);
        var relationship = new Relationship(TestCatalog, TestCreationInfo, RelationshipType.describes,
            from, [to])
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Completeness = RelationshipCompleteness.complete,
            StartTime = PredictableDateTime,
            EndTime = PredictableDateTime
        };

        const string expected = """
                                {
                                  "completeness": "complete",
                                  "endTime": "2025-02-22T01:23:45Z",
                                  "from": "urn:ElementConcreteTestFixture:40f",
                                  "relationshipType": "describes",
                                  "startTime": "2025-02-22T01:23:45Z",
                                  "to": [
                                    "urn:ElementConcreteTestFixture:41c"
                                  ],
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "Relationship",
                                  "spdxId": "urn:Relationship:429"
                                }
                                """;

        // Act
        var json = ToJson(relationship);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void Relationship_Requires_AtLeastOne_To()
    {
        // Arrange
        var from = new ElementConcreteTestFixture(TestCatalog, TestCreationInfo);
        var relationship = new Relationship(TestCatalog, TestCreationInfo, RelationshipType.describes,
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
        var from = new ElementConcreteTestFixture(TestCatalog, TestCreationInfo);
        var to = new ElementConcreteTestFixture(TestCatalog, TestCreationInfo);
        var relationship = new Relationship(TestCatalog, TestCreationInfo, RelationshipType.describes,
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