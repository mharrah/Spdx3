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
}