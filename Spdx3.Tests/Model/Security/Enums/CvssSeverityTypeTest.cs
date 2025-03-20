using Spdx3.Model.Security.Enums;

namespace Spdx3.Tests.Model.Security.Enums;

public class CvssSeverityTypeTest
{
    [Fact]
    public void CvssSeverityType_HasCorrect_Count()
    {
        Assert.Equal(5, Enum.GetValues(typeof(CvssSeverityType)).Length);
    }
}