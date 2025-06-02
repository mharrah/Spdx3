using System.Text.Json.Serialization;

namespace ProduceSourceSbom.NuGetApi.RestModel.Registration;

public class Package
{
    [JsonPropertyName("catalogEntry")]
    public CatalogEntry? CatalogEntry { get; set; }

    [JsonPropertyName("commitId")]
    public string? CommitId { get; set; }

    [JsonPropertyName("commitTimeStamp")]
    public string? CommitTimeStamp { get; set; }

    [JsonPropertyName("packageContent")]
    public string? PackageContent { get; set; }

    [JsonPropertyName("registration")]
    public string? Registration { get; set; }
}