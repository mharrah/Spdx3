using Spdx3.Model.Security.Enums;

namespace Spdx3.Tests.Model.Security.Enums;

public class SsvcDecisionTypeTest
{
    [Fact]
    public void SsvcDecisionType_HasCorrect_Count()
    {
        Assert.Equal(4, Enum.GetValues(typeof(SsvcDecisionType)).Length);
    }
}