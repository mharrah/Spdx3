using System.Text.Json;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Enums;

public class LifecycleScopeTypeTest
{
    [Fact]
    public void LifecycleScopeType_HasCorrect_Count()
    {
        Assert.Equal(6, Enum.GetValues(typeof(LifecycleScopeType)).Length);
    }

    [Fact]
    public void LifecycleScopeType_Single_SerializesAsString()
    {
        // Arrange
        const LifecycleScopeType enumVal = LifecycleScopeType.development;

        // Act
        var json = JsonSerializer.Serialize<object>(Convert.ChangeType(enumVal, typeof(object)));

        // Assert
        Assert.Equal("\"development\"", json);
    }

    [Fact]
    public void LifecycleScopeType_Array_SerializesAsStrings()
    {
        // Arrange
        var enumArray = new[]
        {
            LifecycleScopeType.build,
            LifecycleScopeType.design,
            LifecycleScopeType.development,
            LifecycleScopeType.other,
            LifecycleScopeType.runtime,
            LifecycleScopeType.test
        };

        // Act
        var json = JsonSerializer.Serialize<object>((object)enumArray);

        const string expected = """
                                ["build","design","development","other","runtime","test"]
                                """;

        // Assert
        Assert.Equal(expected, json);
    }
}