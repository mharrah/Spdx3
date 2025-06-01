// ReSharper disable UnusedMember.Global

namespace Spdx3.Model.AI.Enums;

/// <summary>
///     Specifies the safety risk level
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/AI/Vocabularies/SafetyRiskAssessmentType/
/// </summary>
public enum SafetyRiskAssessmentType
{
    high,
    low,
    medium,
    serious
}