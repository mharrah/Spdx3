using System.Text.Json;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Enums;

public class RelationshipCompletenessTest
{
    [Fact]
    public void RelationshipCompleteness_HasCorrect_Count()
    {
        Assert.Equal(3, Enum.GetValues(typeof(RelationshipCompleteness)).Length);
    }

    [Fact]
    public void RelationshipCompleteness_Single_SerializesAsString()
    {
        // Arrange
        const RelationshipCompleteness enumVal = RelationshipCompleteness.noAssertion;

        // Act
        var json = JsonSerializer.Serialize(Convert.ChangeType(enumVal, typeof(object)));

        // Assert
        Assert.Equal("\"noAssertion\"", json);
    }

    [Fact]
    public void RelationshipCompleteness_Array_SerializesAsStrings()
    {
        // Arrange
        var enumArray = new[]
        {
            RelationshipCompleteness.complete,
            RelationshipCompleteness.incomplete,
            RelationshipCompleteness.noAssertion
        };

        // Act
        var json = JsonSerializer.Serialize<object>(enumArray);

        const string expected = """
                                ["complete","incomplete","noAssertion"]
                                """;

        // Assert
        Assert.Equal(expected, json);
    }
}