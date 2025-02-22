using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.Enums;

/// <summary>
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Vocabularies/ProfileIdentifierType/
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ProfileIdentifierType
{
    ai,
    build,
    core,
    dataset,
    expandedLicensing,
    extension,
    lite,
    security,
    simpleLicensing,
    software
}