// ReSharper disable UnusedMember.Global

namespace Spdx3.Model.Security.Enums;

/// <summary>
/// Specifies the VEX justification type.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Security/Vocabularies/VexJustificationType/
/// </summary>
public enum VexJustificationType
{
    componentNotPresent,
    inlineMitigationsAlreadyExist,
    vulnerableCodeCannotBeControlledByAdversary,
    vulnerableCodeNotInExecutePath,
    vulnerableCodeNotPresent
}