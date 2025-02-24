using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.NonElements;

public class NamespaceMap : BaseSpdxClass
{
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
    
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Prefix));
        ValidateRequiredProperty(nameof(Namespace));
    }
}