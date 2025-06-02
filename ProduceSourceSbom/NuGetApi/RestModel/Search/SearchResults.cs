using System.Text.Json.Serialization;

namespace ProduceSourceSbom.NuGetApi.RestModel.Search;

public class SearchResults
{
    [JsonPropertyName("data")]
    public List<NugetSearchResult>? Registrations { get; set; }

    [JsonPropertyName("totalHits")]
    public int? TotalHits { get; set; }
}