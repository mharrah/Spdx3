using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A reference to a resource identifier defined outside the scope of SPDX-3.0 content that uniquely identifies an
///     Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ExternalIdentifier/
/// </summary>
public class ExternalIdentifier : BaseSpdxClass
{
    public ExternalIdentifier()
    {
    }

    public ExternalIdentifier(ExternalIdentifierType externalIdentifierType)
    {
        ExternalIdentifierType = externalIdentifierType;
    }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("externalIdentifierType")]
    public ExternalIdentifierType? ExternalIdentifierType { get; set; }

    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    [JsonPropertyName("identifierLocator")]
    public IList<string> IdentifierLocator { get; } = new List<string>();

    [JsonPropertyName("issuingAuthority")]
    public string? IssuingAuthority { get; set; }

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Identifier));
        ValidateRequiredProperty(nameof(ExternalIdentifierType));
    }
}