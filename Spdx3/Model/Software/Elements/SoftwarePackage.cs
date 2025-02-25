using System.Text.Json.Serialization;

namespace Spdx3.Model.Software.Elements;

public class SoftwarePackage : SoftwareArtifact
{
    [JsonPropertyName("packageVersion")]
    public string? PackageVersion { get; set; }

    [JsonPropertyName("downloadLocation")]
    public string? DownloadLocation { get; set; }

    [JsonPropertyName("packageUrl")]
    public string? PackageUrl { get; set; }

    [JsonPropertyName("homePage")]
    public string? HomePage { get; set; }

    [JsonPropertyName("sourceInfo")]
    public string? SourceInfo { get; set; }
}