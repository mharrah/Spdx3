using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Classes;

public abstract class SoftwareArtifact : Artifact
{
    // protected internal no-parm constructor required for deserialization
    protected internal SoftwareArtifact()
    {
    }

    [SetsRequiredMembers]
    protected SoftwareArtifact(SpdxCatalog spdxCatalog, CreationInfo creationInfo) : base(spdxCatalog,
        creationInfo)
    {
    }

    [JsonPropertyName("copyrightText")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
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