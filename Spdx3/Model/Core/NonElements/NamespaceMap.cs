using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A mapping between prefixes and namespace partial URIs.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/NamespaceMap/
/// </summary>
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