// ReSharper disable UnusedMember.Global

namespace Spdx3.Model.Software.Enums;

/// <summary>
///     Type of SBOM
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Software/Vocabularies/SbomType/
/// </summary>
public enum SbomType
{
    analyzed,
    build,
    deployed,
    design,
    runtime,
    source
}