using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Classes;

public class ContentIdentifier : IntegrityMethod
{
    [JsonPropertyName("software_contentIdentifierType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public ContentIdentifierType ContentIdentifierType { get; set; }

    [JsonPropertyName("software_contentIdentifierValue")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? ContentIdentifierValue { get; set; }

    // protected internal no-parm constructor required for deserialization
    protected internal ContentIdentifier()
    {
    }

    [SetsRequiredMembers]
    public ContentIdentifier(Catalog catalog, ContentIdentifierType contentIdentifierType,
        string contentIdentifierValue) : base(catalog)
    {
        ContentIdentifierType = contentIdentifierType;
        ContentIdentifierValue = contentIdentifierValue;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(ContentIdentifierType));
        ValidateRequiredProperty(nameof(ContentIdentifierValue));
    }
}