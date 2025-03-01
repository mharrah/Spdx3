using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A reference to a resource identifier defined outside the scope of SPDX-3.0 content that uniquely identifies an
///     Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ExternalIdentifier/
/// </summary>
public class ExternalIdentifier : BaseSpdxClass
{
    internal ExternalIdentifier()
    {
    }

    internal ExternalIdentifier(ExternalIdentifierType externalIdentifierType)
    {
        ExternalIdentifierType = externalIdentifierType;
    }

    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Comment { get; set; }

    [JsonPropertyName("externalIdentifierType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public ExternalIdentifierType? ExternalIdentifierType { get; set; }

    [JsonPropertyName("identifier")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Identifier { get; set; }

    [JsonPropertyName("identifierLocator")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<string> IdentifierLocator { get; } = new List<string>();

    [JsonPropertyName("issuingAuthority")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? IssuingAuthority { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Identifier));
        ValidateRequiredProperty(nameof(ExternalIdentifierType));
    }
}