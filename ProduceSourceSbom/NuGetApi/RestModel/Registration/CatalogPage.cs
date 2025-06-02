using System.Text.Json.Serialization;

namespace ProduceSourceSbom.NuGetApi.RestModel.Registration;

public class CatalogPage
{
    [JsonPropertyName("commitId")]
    public string? CommitId { get; set; }

    [JsonPropertyName("commitTimeStamp")]
    public string? CommitTimeStamp { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }

    [JsonPropertyName("lower")]
    public string? Lower { get; set; }

    [JsonPropertyName("items")]
    public List<Package>? Packages { get; set; }

    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    [JsonPropertyName("upper")]
    public string? Upper { get; set; }
}