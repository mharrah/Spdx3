using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.NonElements;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Elements;

public class Package : SoftwareArtifact
{
    [SetsRequiredMembers]
    public Package(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
    }

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