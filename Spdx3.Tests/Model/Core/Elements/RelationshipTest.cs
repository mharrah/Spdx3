using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Elements;

public class RelationshipTest : BaseElementTestClass
{
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
                                  "startTime": "2025-02-22T01:23:45+00:00",
                                  "endTime": "2025-02-22T01:23:45+00:00",
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
}