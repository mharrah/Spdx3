using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Utility;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A reference to a resource identifier defined outside the scope of SPDX-3.0 content that uniquely identifies an
///     Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ExternalIdentifier/
/// </summary>
[method: SetsRequiredMembers]
public class ExternalIdentifier
{
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("externalIdentifierType")]
    public string ExternalIdentifierType { get; set; }

    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("identifierLocator")]
    public IList<string> IdentifierLocator { get; } = new List<string>();

    [JsonPropertyName("issuingAuthority")]
    public string? IssuingAuthority { get; set; }
}