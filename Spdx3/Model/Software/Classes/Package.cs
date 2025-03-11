using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Classes;

public class Package : SoftwareArtifact
{
    // protected internal no-parm constructor required for deserialization
    protected internal Package()
    {
    }

    
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