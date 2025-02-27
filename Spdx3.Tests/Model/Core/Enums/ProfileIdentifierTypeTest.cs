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
}