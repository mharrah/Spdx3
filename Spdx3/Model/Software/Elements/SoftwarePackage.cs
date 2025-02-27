using System.Text.Json.Serialization;
using Spdx3.Serialization;

namespace Spdx3.Model.Software.Elements;

public class SoftwarePackage : SoftwareArtifact
{
    [JsonPropertyName("packageVersion")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? PackageVersion { get; set; }

    [JsonPropertyName("downloadLocation")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? DownloadLocation { get; set; }

    [JsonPropertyName("packageUrl")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? PackageUrl { get; set; }

    [JsonPropertyName("homePage")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? HomePage { get; set; }

    [JsonPropertyName("sourceInfo")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? SourceInfo { get; set; }
}