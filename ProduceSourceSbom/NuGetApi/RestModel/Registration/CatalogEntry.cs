using System.Text.Json.Serialization;

namespace ProduceSourceSbom.NuGetApi.RestModel.Registration;

public class CatalogEntry
{
    [JsonPropertyName("authors")]
    public string? Authors { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("iconUrl")]
    public string? IconUrl { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("licenseExpression")]
    public string? LicenseExpression { get; set; }

    [JsonPropertyName("licenseUrl")]
    public string? LicenseUrl { get; set; }

    [JsonPropertyName("listed")]
    public bool? Listed { get; set; }

    [JsonPropertyName("minClientVersion")]
    public string? MinClientVersion { get; set; }

    [JsonPropertyName("packageContent")]
    public string? PackageContent { get; set; }

    [JsonPropertyName("projectUrl")]
    public string? ProjectUrl { get; set; }

    [JsonPropertyName("published")]
    public string? Published { get; set; }

    [JsonPropertyName("requireLicenseAcceptance")]
    public bool? RequireLicenseAcceptance { get; set; }

    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}