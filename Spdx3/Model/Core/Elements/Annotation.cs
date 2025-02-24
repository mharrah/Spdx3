using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Model.Core.Elements;

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