using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.Enums;

/// <summary>
///     Type of annotation
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Vocabularies/AnnotationType/
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AnnotationType
{
    other,
    review
}