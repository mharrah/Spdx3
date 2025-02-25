using System.Text.Json;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Enums;

public class ExternalIdentifierTypeTest
{
    [Fact]
    public void ExternalIdentifierType_HasCorrect_Count()
    {
        Assert.Equal(11, Enum.GetValues(typeof(ExternalIdentifierType)).Length);
    }

    [Fact]
    public void ExternalIdentifierType_Single_SerializesAsString()
    {
        // Arrange
        const ExternalIdentifierType enumVal = ExternalIdentifierType.securityOther;

        // Act
        var json = JsonSerializer.Serialize<object>(Convert.ChangeType(enumVal, typeof(object)));

        // Assert
        Assert.Equal("\"securityOther\"", json);
    }

    [Fact]
    public void ExternalIdentifierType_Array_SerializesAsStrings()
    {
        // Arrange
        var enumArray = new[]
        {
            ExternalIdentifierType.cpe22,
            ExternalIdentifierType.cpe23,
            ExternalIdentifierType.cve,
            ExternalIdentifierType.email,
            ExternalIdentifierType.gitoid,
            ExternalIdentifierType.other,
            ExternalIdentifierType.packageUrl,
            ExternalIdentifierType.securityOther,
            ExternalIdentifierType.swhid,
            ExternalIdentifierType.swid,
            ExternalIdentifierType.urlScheme
        };

        // Act
        var json = JsonSerializer.Serialize<object>((object)enumArray);

        const string expected = """
                                ["cpe22","cpe23","cve","email","gitoid","other","packageUrl","securityOther","swhid","swid","urlScheme"]
                                """;

        // Assert
        Assert.Equal(expected, json);
    }
}