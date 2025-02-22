using System.Text.Json.Serialization;

namespace Spdx3.Model.Software.Enums;

/// <summary>
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Software/Vocabularies/ContentIdentifierType/
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ContentIdentifier
{
    gitoid,
    swhid
}