using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     An assertion made in relation to one or more elements.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Annotation/
/// </summary>
public class Annotation : Element
{
    // protected internal no-parm constructor required for deserialization
    protected internal Annotation()
    {
    }
    
    [SetsRequiredMembers]
    public Annotation(SpdxCatalog spdxCatalog, CreationInfo creationInfo, AnnotationType annotationType,
        Element subject) : base(spdxCatalog, creationInfo)
    {
        AnnotationType = annotationType;
        Subject = subject;
    }

    [JsonPropertyName("subject")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required Element Subject { get; set; }

    [JsonPropertyName("annotationType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required AnnotationType AnnotationType { get; set; }

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
}