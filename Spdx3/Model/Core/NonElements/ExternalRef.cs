using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
/// A reference to a resource outside the scope of SPDX-3.0 content related to an Element.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ExternalRef/
/// </summary>
public class ExternalRef : BaseSpdxClass
{
    [JsonPropertyName("externalRefType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public ExternalRefType? ExternalRefType { get; set; }

    [JsonPropertyName("locator")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<string> Locator { get; set; } = new List<string>();

    [JsonPropertyName("contentType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? ContentType { get; set; }

    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Comment { get; set; }

    internal ExternalRef()
    {
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(ExternalRefType));
    }
}