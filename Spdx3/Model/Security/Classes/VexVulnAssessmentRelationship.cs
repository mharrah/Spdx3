using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Security.Classes;

/// <summary>
/// VexVulnAssessmentRelationship is an abstract subclass that defined the common properties shared by all the SPDX-VEX status relationships.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Security/Classes/VexVulnAssessmentRelationship/
/// </summary>
public class VexVulnAssessmentRelationship :VulnAssessmentRelationship
{
    [JsonPropertyName("security_statusNotes")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string? StatusNotes { get; set; }
    
    [JsonPropertyName("security_vexVersion")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string? VexVersion { get; set; }
    
    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal VexVulnAssessmentRelationship()
    {
    }
#pragma warning restore CS8618, CS9264
    
    [SetsRequiredMembers]
    public VexVulnAssessmentRelationship(Catalog catalog, CreationInfo creationInfo, RelationshipType relationshipType,
        Vulnerability from, List<Element> to) 
        : base(catalog, creationInfo, relationshipType, from, to)
    {
    }

    public override void Validate()
    {
        base.Validate();
        
    }
}