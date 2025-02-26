using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
/// A reference to a resource outside the scope of SPDX-3.0 content related to an Element.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ExternalRef/
/// </summary>
public class ExternalRef : BaseSpdxClass
{
    [JsonPropertyName("externalRefType")]
    public string? ExternalRefType { get; set; }
    
    [JsonPropertyName("locator")]
    public IList<string>? Locator { get; set; } = new List<string>();
    
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }
    
    [JsonPropertyName("conmment")]
    public string? Conment { get; set; }
    
    internal ExternalRef()
    {
    }

    public new void Validate()
    {  
        base.Validate();
        ValidateRequiredProperty(nameof(ExternalRefType));
    }
}