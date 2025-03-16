using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Classes;

public class Package : SoftwareArtifact
{
    [JsonPropertyName("software_packageVersion")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? PackageVersion { get; set; }

    [JsonPropertyName("software_downloadLocation")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? DownloadLocation { get; set; }

    [JsonPropertyName("software_packageUrl")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? PackageUrl { get; set; }

    [JsonPropertyName("software_homePage")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? HomePage { get; set; }

    [JsonPropertyName("software_sourceInfo")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? SourceInfo { get; set; }

    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal Package()
    {
    }


    [SetsRequiredMembers]
    public Package(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}