using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Lite;
using Spdx3.Serialization;
using Spdx3.Utility;

// ReSharper disable UnusedMember.Global

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A reference to a resource identifier defined outside the scope of SPDX-3.0 content that uniquely identifies an
///     Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ExternalIdentifier/
/// </summary>
public class ExternalIdentifier : BaseModelClass, ILiteDomainCompliantElement
{
    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? Comment { get; set; }

    [JsonPropertyName("externalIdentifierType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required ExternalIdentifierType ExternalIdentifierType { get; set; }

    [JsonPropertyName("identifier")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string Identifier { get; set; }

    [JsonPropertyName("identifierLocator")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<Uri> IdentifierLocator { get; } = new List<Uri>();

    [JsonPropertyName("issuingAuthority")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? IssuingAuthority { get; set; }

    // protected internal no-parm constructor required for deserialization
    protected internal ExternalIdentifier()
    {
    }

    [SetsRequiredMembers]
    public ExternalIdentifier(Catalog catalog, ExternalIdentifierType externalIdentifierType, string identifier) :
        base(catalog)
    {
        ExternalIdentifierType = externalIdentifierType;
        Identifier = identifier;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Identifier));
        ValidateRequiredProperty(nameof(ExternalIdentifierType));
    }

    public void Accept(ILiteDomainComplianceVisitor visitor)
    {
        visitor.Visit(this);
    }
}