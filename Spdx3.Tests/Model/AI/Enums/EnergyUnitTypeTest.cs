using Spdx3.Model.AI.Enums;

namespace Spdx3.Tests.Model.AI.Enums;

public class EnergyUnitTypeTest
{
    [Fact]
    public void EnergyUnitType_HasCorrect_Count()
    {
        Assert.Equal(3, Enum.GetValues(typeof(EnergyUnitType)).Length);
    }
}