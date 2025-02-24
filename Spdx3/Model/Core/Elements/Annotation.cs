using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Model.Core.Elements;

/// <summary>
/// An assertion made in relation to one or more elements.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Annotation/
/// </summary>
public class Annotation : Element
{
    [JsonPropertyName("subject")]
    public string? SubjectRef { get; set; }
    
    [JsonPropertyName("annotationType")]
    public AnnotationType? AnnotationType { get; set; }
    
    [JsonPropertyName("statement")]
    public string? Statement { get; set; }
        
    [JsonPropertyName("mediaType")]
    public string? MediaType { get; set; }

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(AnnotationType));
        ValidateRequiredProperty(nameof(SubjectRef));
    }
}