using System.Text.Json.Serialization;

namespace ProduceSourceSbom.NuGetApi.RestModel.Registration;

public class PackageRegistration
{
    [JsonPropertyName("items")]
    public List<CatalogPage>? CatalogPages { get; set; }

    [JsonPropertyName("commitId")]
    public string? CommitId { get; set; }

    [JsonPropertyName("commitTimeStamp")]
    public string? CommitTimeStamp { get; set; }

    [JsonPropertyName("count")]
    public int? Count { get; set; }
}