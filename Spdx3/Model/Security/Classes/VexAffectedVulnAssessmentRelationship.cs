using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Security.Classes;

/// <summary>
/// Connects a vulnerability and an element designating the element as a product affected by the vulnerability.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Security/Classes/VexAffectedVulnAssessmentRelationship/
/// </summary>
public class VexAffectedVulnAssessmentRelationship : VexVulnAssessmentRelationship
{
    [JsonPropertyName("security_actionStatement")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string ActionStatement { get; set; }
    
    [JsonPropertyName("security_actionStatementTime")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public DateTimeOffset? ActionStatementTime { get; set; }
    
    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal VexAffectedVulnAssessmentRelationship()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public VexAffectedVulnAssessmentRelationship(Catalog catalog, CreationInfo creationInfo, Vulnerability from, 
        List<Element> to, string actionStatement) 
        : base(catalog, creationInfo, RelationshipType.affects, from, to)
    {
        this.ActionStatement = actionStatement;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(ActionStatement));
    }
}