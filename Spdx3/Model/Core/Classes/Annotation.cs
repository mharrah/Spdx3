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
    [JsonPropertyName("subject")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required Element Subject { get; set; }

    [JsonPropertyName("annotationType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required AnnotationType AnnotationType { get; set; }

    [JsonPropertyName("statement")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? Statement { get; set; }

    [JsonPropertyName("contentType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? ContentType { get; set; }

    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal Annotation()
    {
    }

    [SetsRequiredMembers]
    public Annotation(Catalog catalog, CreationInfo creationInfo, AnnotationType annotationType, Element subject) :
        base(catalog, creationInfo)
    {
        AnnotationType = annotationType;
        Subject = subject;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(AnnotationType));
        ValidateRequiredProperty(nameof(Subject));
    }
}