using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Software.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Security.Classes;

public abstract class VulnAssessmentRelationship : Relationship
{
    [JsonPropertyName("security_suppliedBy")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public Agent? SuppliedBy { get; set; }
    
    [JsonPropertyName("security_assessedElement")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public SoftwareArtifact? AssessedElement { get; set; }
    
    [JsonPropertyName("security_modifiedTime")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public DateTimeOffset? ModifiedTime { get; set; }
    
    [JsonPropertyName("security_publishedTime")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public DateTimeOffset? PublishedTime { get; set; }
    
    [JsonPropertyName("security_withdrawnTime")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public DateTimeOffset? WithdrawnTime { get; set; }
    
    
    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal VulnAssessmentRelationship()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    protected VulnAssessmentRelationship(Catalog catalog, CreationInfo creationInfo,
        RelationshipType relationshipType, Element from, List<Element> to) : base(catalog, creationInfo, relationshipType, from, to)
    {
    }    
    
}