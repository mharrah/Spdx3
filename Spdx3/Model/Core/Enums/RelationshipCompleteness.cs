using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.Enums;

/// <summary>
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Vocabularies/RelationshipCompleteness/
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RelationshipCompleteness
{
    complete,
    incomplete,
    noAssertion
}