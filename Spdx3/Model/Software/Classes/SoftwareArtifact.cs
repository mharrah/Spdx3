using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Classes;

public abstract class SoftwareArtifact : Artifact
{
    [JsonPropertyName("copyrightText")] [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? CopyrightText;


    [JsonPropertyName("additionalPurpose")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<SoftwarePurpose> AdditionalPurpose { get; } = new List<SoftwarePurpose>();

    [JsonPropertyName("contentIdentifier")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<ContentIdentifier> ContentIdentifier { get; } = new List<ContentIdentifier>();

    [JsonPropertyName("primaryPurpose")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public SoftwarePurpose? PrimaryPurpose { get; set; }

    [JsonPropertyName("attributionText")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<string> AttributionText { get; } = new List<string>();

    // protected internal no-parm constructor required for deserialization
    protected internal SoftwareArtifact()
    {
    }

    [SetsRequiredMembers]
    protected SoftwareArtifact(Catalog catalog, CreationInfo creationInfo) : base(catalog,
        creationInfo)
    {
    }
}