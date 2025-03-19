using Spdx3.Model.AI.Enums;

namespace Spdx3.Tests.Model.AI.Enums;

public class SafetyRiskAssessmentTypeTest
{
    [Fact]
    public void SafetyRiskAssessmentType__HasCorrect_Count()
    {
        Assert.Equal(4, Enum.GetValues(typeof(SafetyRiskAssessmentType)).Length);
    }
}