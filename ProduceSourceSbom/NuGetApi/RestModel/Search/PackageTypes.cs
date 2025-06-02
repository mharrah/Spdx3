using System.Text.Json.Serialization;

namespace ProduceSourceSbom.NuGetApi.RestModel.Search;

public class PackageTypes
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}