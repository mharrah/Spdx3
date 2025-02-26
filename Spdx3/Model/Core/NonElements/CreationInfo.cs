using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     Provides information about the creation of the Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/CreationInfo/
/// </summary>
public class CreationInfo : BaseSpdxClass
{
    [JsonPropertyName("createdBy")]
    public IList<string> CreatedByAgentRefs { get; } = new List<string>();

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("created")]
    public DateTimeOffset? Created { get; set; }

    [JsonPropertyName("createdUsing")]
    public IList<string> CreatedUsingToolRefs { get; } = new List<string>();

    [JsonPropertyName("specVersion")]
    public string SpecVersion { get; set; } = "3.0.1";

    internal CreationInfo()
    {
    }
    
}