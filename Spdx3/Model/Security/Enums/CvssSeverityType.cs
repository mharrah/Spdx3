// ReSharper disable UnusedMember.Global

namespace Spdx3.Model.Security.Enums;

/// <summary>
/// Specifies the CVSS base, temporal, threat, or environmental severity type.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Security/Vocabularies/CvssSeverityType/
/// </summary>
public enum CvssSeverityType
{
    critical,
    high,
    medium,
    low,
    none
}