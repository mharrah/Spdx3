using System.Text.Json.Serialization;

namespace ProduceSourceSbom.NuGetApi.RestModel.Search;

public class Versions
{
    [JsonPropertyName("downloads")]
    public int? Downloads { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}