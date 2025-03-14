using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Classes;

public abstract class SoftwareArtifact : Artifact
{
    [JsonPropertyName("software_copyrightText")] 
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? CopyrightText;

    [JsonPropertyName("software_additionalPurpose")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<SoftwarePurpose> AdditionalPurpose { get; } = new List<SoftwarePurpose>();

    [JsonPropertyName("software_contentIdentifier")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<ContentIdentifier> ContentIdentifier { get; } = new List<ContentIdentifier>();

    [JsonPropertyName("software_primaryPurpose")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public SoftwarePurpose? PrimaryPurpose { get; set; }

    [JsonPropertyName("software_attributionText")]
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