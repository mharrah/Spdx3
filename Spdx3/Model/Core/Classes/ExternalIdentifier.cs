using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A reference to a resource identifier defined outside the scope of SPDX-3.0 content that uniquely identifies an
///     Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ExternalIdentifier/
/// </summary>
public class ExternalIdentifier : BaseSpdxClass
{
    // protected internal no-parm constructor required for deserialization
    protected internal ExternalIdentifier()
    {
    }
    
    [SetsRequiredMembers]
    public ExternalIdentifier(SpdxCatalog spdxCatalog, ExternalIdentifierType externalIdentifierType,
        string identifier) : base(spdxCatalog)
    {
        ExternalIdentifierType = externalIdentifierType;
        Identifier = identifier;
    }

    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Comment { get; set; }

    [JsonPropertyName("externalIdentifierType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required ExternalIdentifierType ExternalIdentifierType { get; set; }

    [JsonPropertyName("identifier")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string Identifier { get; set; }

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