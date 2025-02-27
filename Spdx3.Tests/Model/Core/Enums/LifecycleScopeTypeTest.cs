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
}