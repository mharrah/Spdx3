using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.Elements;

public class LifecycleScopedRelationshipTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_LifecycleScopedRelationship_SerializesProperly()
    {
        // Arrange
        var from = TestFactory.New<TestElement>(TestCreationInfo);
        var to = TestFactory.New<TestElement>(TestCreationInfo);
        var relationship = TestFactory.New<LifecycleScopedRelationship>(TestCreationInfo, RelationshipType.describes,
            from, [to]);
        const string expected = """
                                {
                                  "from": "urn:TestElement:402",
                                  "to": [
                                    "urn:TestElement:40f"
                                  ],
                                  "relationshipType": "describes",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "LifecycleScopedRelationship",
                                  "spdxId": "urn:LifecycleScopedRelationship:41c"
                                }
                                """;

        // Act
        var json = relationship.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_LifecycleScopedRelationship_SerializesProperly()
    {
        // Arrange
        var from = TestFactory.New<TestElement>(TestCreationInfo);
        var to = TestFactory.New<TestElement>(TestCreationInfo);
        var relationship = TestFactory.New<LifecycleScopedRelationship>(TestCreationInfo, RelationshipType.describes,
            from, [to]);
        relationship.Comment = "TestComment";
        relationship.Description = "TestDescription";
        relationship.Name = "TestName";
        relationship.Completeness = RelationshipCompleteness.complete;
        relationship.StartTime = PredictableDateTime;
        relationship.EndTime = PredictableDateTime;
        relationship.Scope = LifecycleScopeType.runtime;

        const string expected = """
                                {
                                  "scope": "runtime",
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
                                  "type": "LifecycleScopedRelationship",
                                  "spdxId": "urn:LifecycleScopedRelationship:41c"
                                }
                                """;

        // Act
        var json = relationship.ToJson();

        // Assert
        Assert.Equal(expected, json);
    }
}