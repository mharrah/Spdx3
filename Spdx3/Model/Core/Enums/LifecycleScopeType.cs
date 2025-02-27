using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.Enums;

/// <summary>
///     Lifecycle phases that can provide context to relationships.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Vocabularies/LifecycleScopeType/
/// </summary>
public enum LifecycleScopeType
{
    build,
    design,
    development,
    other,
    runtime,
    test
}