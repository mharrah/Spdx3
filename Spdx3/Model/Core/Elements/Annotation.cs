using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     An assertion made in relation to one or more elements.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Annotation/
/// </summary>
public class Annotation : Element
{
    [JsonPropertyName("subject")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public Element? Subject { get; set; }

    [JsonPropertyName("annotationType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public AnnotationType? AnnotationType { get; set; }

    [JsonPropertyName("statement")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Statement { get; set; }

    [JsonPropertyName("mediaType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? MediaType { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(AnnotationType));
        ValidateRequiredProperty(nameof(Subject));
    }

    internal Annotation()
    {
    }
}