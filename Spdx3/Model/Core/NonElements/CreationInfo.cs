using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.NonElements;

public class CreationInfo : BaseSpdxClass
{
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("created)")]
    public DateTimeOffset Created { get; set; }
        
    /*
    createdBy	Agent	1	*
    createdUsing	Tool	0	*
    specVersion	SemVer	1	1
    */
    [JsonPropertyName("specVersion")]
    public required string SpecVersion { get; set; } = "3.0.1";
  
}