// ReSharper disable UnusedMember.Global

namespace Spdx3.Model.Core.Enums;

/// <summary>
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Vocabularies/SupportType/
/// </summary>
public enum SupportType
{
    deployed,
    development,
    endOfSupport,
    limitedSupport,
    noAssertion,
    noSupport,
    support
}