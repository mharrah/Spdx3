using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A reference to a resource outside the scope of SPDX-3.0 content related to an Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ExternalRef/
/// </summary>
public class ExternalRef : BaseSpdxClass
{
    [SetsRequiredMembers]
    public ExternalRef(SpdxIdFactory spdxIdFactory, ExternalRefType externalRefType) : base(spdxIdFactory)
    {
        ExternalRefType = externalRefType;
    }

    [JsonPropertyName("externalRefType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required ExternalRefType ExternalRefType { get; set; }

    [JsonPropertyName("locator")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<string> Locator { get; set; } = new List<string>();

    [JsonPropertyName("contentType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? ContentType { get; set; }

    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Comment { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(ExternalRefType));
    }
}