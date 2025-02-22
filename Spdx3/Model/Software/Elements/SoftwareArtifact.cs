using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;
using Spdx3.Model.Software.Enums;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Elements;

[method: SetsRequiredMembers]
public abstract class SoftwareArtifact(ISpdxIdFactory idFactory, string artifactType, CreationInfo creationInfo)
    : Artifact(idFactory, artifactType, creationInfo)
{
    [JsonPropertyName("additionalPurpose")]
    public IList<SoftwarePurpose> AdditionalPurpose => _additionalPurpose;

    [JsonPropertyName("contentIdentifier")]
    public IList<ContentIdentifier> ContentIdentifier { get; } = new List<ContentIdentifier>();

    [JsonPropertyName("primaryPurpose")]
    public SoftwarePurpose? PrimaryPurpose { get; set;  }

    [JsonPropertyName("copyrightText")]
    public string? CopyrightText;

    private readonly IList<SoftwarePurpose> _additionalPurpose = new List<SoftwarePurpose>();

    [JsonPropertyName("attributionText")]
    public IList<string> AttributionText { get; } = new List<string>();
}