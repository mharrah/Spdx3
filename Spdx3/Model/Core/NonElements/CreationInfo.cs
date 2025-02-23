using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.NonElements;

[method: SetsRequiredMembers]
public class CreationInfo() : BaseSpdxClass
{
    [JsonPropertyName("createdBy")]
    public IList<string> CreatedByAgentRefs { get; set; } = new List<string>();

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("created")]
    public DateTimeOffset Created { get; set; }

    [JsonPropertyName("createdUsing")]
    public IList<string> CreatedUsingToolRefs { get; set; } = new List<string>();

    /*
    createdBy	Agent	1	*
    createdUsing	Tool	0	*
    specVersion	SemVer	1	1
    */
    [JsonPropertyName("specVersion")]
    public string SpecVersion { get; set; } = "3.0.1";
}