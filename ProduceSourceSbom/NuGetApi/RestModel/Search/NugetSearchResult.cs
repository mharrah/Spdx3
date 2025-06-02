using System.Text.Json.Serialization;

namespace ProduceSourceSbom.NuGetApi.RestModel.Search;

public class NugetSearchResult
{
    [JsonPropertyName("authors")]
    public List<string>? Authors { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("iconUrl")]
    public string? IconUrl { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("licenseUrl")]
    public string? LicenseUrl { get; set; }

    [JsonPropertyName("owners")]
    public List<string>? Owners { get; set; }

    [JsonPropertyName("packageTypes")]
    public List<PackageTypes>? PackageTypes { get; set; }

    [JsonPropertyName("projectUrl")]
    public string? ProjectUrl { get; set; }

    [JsonPropertyName("registration")]
    public string? Registration { get; set; }

    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("totalDownloads")]
    public int? TotalDownloads { get; set; }

    [JsonPropertyName("verified")]
    public bool? Verified { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("versions")]
    public List<Versions>? Versions { get; set; }
}