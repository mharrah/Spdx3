using System.Text.Json;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Tests.Model.Core.Enums;

public class ProfileIdentifierTypeTest
{
    [Fact]
    public void ProfileIdentifierType_HasCorrect_Count()
    {
        Assert.Equal(10, Enum.GetValues(typeof(ProfileIdentifierType)).Length);
    }

    [Fact]
    public void ProfileIdentifierType_Single_SerializesAsString()
    {
        // Arrange
        const ProfileIdentifierType enumVal = ProfileIdentifierType.extension;

        // Act
        var json = JsonSerializer.Serialize(Convert.ChangeType(enumVal, typeof(object)));

        // Assert
        Assert.Equal("\"extension\"", json);
    }

    [Fact]
    public void ProfileIdentifierType_Array_SerializesAsStrings()
    {
        // Arrange
        var enumArray = new[]
        {
            ProfileIdentifierType.ai,
            ProfileIdentifierType.build,
            ProfileIdentifierType.core,
            ProfileIdentifierType.dataset,
            ProfileIdentifierType.expandedLicensing,
            ProfileIdentifierType.extension,
            ProfileIdentifierType.lite,
            ProfileIdentifierType.security,
            ProfileIdentifierType.simpleLicensing,
            ProfileIdentifierType.software
        };

        // Act
        var json = JsonSerializer.Serialize<object>(enumArray);

        // Assert
        const string expected = """
                                ["ai","build","core","dataset","expandedLicensing","extension","lite","security","simpleLicensing","software"]
                                """;

        Assert.Equal(expected, json);
    }
}