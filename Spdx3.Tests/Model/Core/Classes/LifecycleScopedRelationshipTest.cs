using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Classes;

public class LifecycleScopedRelationshipTest : BaseModelTestClass
{
    [Fact]
    public void BrandNew_LifecycleScopedRelationship_SerializesProperly()
    {
        // Arrange
        var from = new TestElement(TestSpdxCatalog, TestCreationInfo);
        var to = new TestElement(TestSpdxCatalog, TestCreationInfo);
        var relationship = new LifecycleScopedRelationship(TestSpdxCatalog, TestCreationInfo,
            RelationshipType.describes,
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
        var json = ToJson(relationship);

        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_LifecycleScopedRelationship_SerializesProperly()
    {
        // Arrange
        var from = new TestElement(TestSpdxCatalog, TestCreationInfo);
        var to = new TestElement(TestSpdxCatalog, TestCreationInfo);
        var relationship = new LifecycleScopedRelationship(TestSpdxCatalog, TestCreationInfo,
            RelationshipType.describes,
            from, [to])
        {
            Comment = "TestComment",
            Description = "TestDescription",
            Name = "TestName",
            Completeness = RelationshipCompleteness.complete,
            StartTime = PredictableDateTime,
            EndTime = PredictableDateTime,
            Scope = LifecycleScopeType.runtime
        };

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
        var json = ToJson(relationship);

        // Assert
        Assert.Equal(expected, json);
    }
}