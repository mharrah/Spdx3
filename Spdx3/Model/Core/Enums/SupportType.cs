using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.Enums;

/// <summary>
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Vocabularies/SupportType/
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
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