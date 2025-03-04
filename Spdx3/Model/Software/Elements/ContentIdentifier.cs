using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.NonElements;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Elements;

public class ContentIdentifier : IntegrityMethod
{
    [SetsRequiredMembers]
    public ContentIdentifier(SpdxIdFactory spdxIdFactory, ContentIdentifierType contentIdentifierType,
        string contentIdentifierValue) : base(spdxIdFactory)
    {
        ContentIdentifierType = contentIdentifierType;
        ContentIdentifierValue = contentIdentifierValue;
    }

    [JsonPropertyName("contentIdentifierType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public ContentIdentifierType ContentIdentifierType { get; set; }

    [JsonPropertyName("contentIdentifierValue")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? ContentIdentifierValue { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(ContentIdentifierType));
        ValidateRequiredProperty(nameof(ContentIdentifierValue));
    }
}