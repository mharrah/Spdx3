using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.Enums;

/// <summary>
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Vocabularies/ExternalIdentifierType/
/// </summary>
public enum ExternalIdentifierType
{
    cpe22,
    cpe23,
    cve,
    email,
    gitoid,
    other,
    packageUrl,
    securityOther,
    swhid,
    swid,
    urlScheme
}