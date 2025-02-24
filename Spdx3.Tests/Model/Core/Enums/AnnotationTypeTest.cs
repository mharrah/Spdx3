using System.Text.Json;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Enums;

public class AnnotationTypeTest
{
    [Fact]
    public void AnnotationType_HasCorrect_Count()
    {
        Assert.Equal(2, Enum.GetValues(typeof(AnnotationType)).Length);
    }

    [Fact]
    public void AnnotationType_Single_SerializesAsString()
    {
        // Arrange
        const AnnotationType enumVal = AnnotationType.review;
        
        // Act
        var json = JsonSerializer.Serialize<object>(Convert.ChangeType(enumVal, typeof(object)));
        
        // Assert
        Assert.Equal("\"review\"", json);
    }

    [Fact]
    public void AnnotationType_Array_SerializesAsStrings()
    {
        // Arrange
        var enumArray = new[]
        {
            AnnotationType.other,
            AnnotationType.review
        };
        
        // Act
        var json = JsonSerializer.Serialize<object>((object) enumArray);

        const string expected = """
                                ["other","review"]
                                """;
        
        // Assert
        Assert.Equal(expected, json);
    }
}