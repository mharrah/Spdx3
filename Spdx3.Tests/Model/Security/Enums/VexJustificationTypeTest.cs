using Spdx3.Model.Security.Enums;

namespace Spdx3.Tests.Model.Security.Enums;

public class VexJustificationTypeTest
{
    [Fact]
    public void VexJustificationType_HasCorrect_Count()
    {
        Assert.Equal(5, Enum.GetValues(typeof(VexJustificationType)).Length);
    }
}