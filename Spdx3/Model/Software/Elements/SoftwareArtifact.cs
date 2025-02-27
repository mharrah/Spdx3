using System.Text.Json.Serialization;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;

namespace Spdx3.Model.Software.Elements;

public abstract class SoftwareArtifact : Artifact
{
    [JsonPropertyName("copyrightText")] [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? CopyrightText;

    [JsonPropertyName("additionalPurpose")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<SoftwarePurpose> AdditionalPurpose { get; } = new List<SoftwarePurpose>();

    [JsonPropertyName("contentIdentifier")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<ContentIdentifier> ContentIdentifier { get; } = new List<ContentIdentifier>();

    [JsonPropertyName("primaryPurpose")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public SoftwarePurpose? PrimaryPurpose { get; set; }

    [JsonPropertyName("attributionText")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<string> AttributionText { get; } = new List<string>();
}