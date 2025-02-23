using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;
using Spdx3.Model.Software.Enums;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Elements;



public abstract class SoftwareArtifact() : Artifact
{
    [JsonPropertyName("copyrightText")]
    public string? CopyrightText;

    [JsonPropertyName("additionalPurpose")]
    public IList<SoftwarePurpose> AdditionalPurpose { get; } = new List<SoftwarePurpose>();

    [JsonPropertyName("contentIdentifier")]
    public IList<ContentIdentifier> ContentIdentifier { get; } = new List<ContentIdentifier>();

    [JsonPropertyName("primaryPurpose")]
    public SoftwarePurpose? PrimaryPurpose { get; set; }

    [JsonPropertyName("attributionText")]
    public IList<string> AttributionText { get; } = new List<string>();
}