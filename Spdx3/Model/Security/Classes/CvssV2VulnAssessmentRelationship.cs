using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Security.Classes;

/// <summary>
/// Provides a CVSS version 2.0 assessment for a vulnerability.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Security/Classes/CvssV2VulnAssessmentRelationship/
/// </summary>
public class CvssV2VulnAssessmentRelationship : VulnAssessmentRelationship
{
    [JsonPropertyName("security_score")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required double? Score { get; set; }
        
    [JsonPropertyName("security_vectorString")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string? VectorString { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Score));
        ValidateRequiredProperty(nameof(VectorString));
        if (RelationshipType.hasAssessmentFor != RelationshipType)
        {
            throw new Spdx3ValidationException(this, nameof(RelationshipType), "Must be 'hasAssessmentFor'");
        }
    }

    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal CvssV2VulnAssessmentRelationship()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public CvssV2VulnAssessmentRelationship(Catalog catalog, CreationInfo creationInfo,
        Element from, List<Element> to, double score, string vectorString) 
        : base(catalog, creationInfo, RelationshipType.hasAssessmentFor, from, to)
    {
        Score = score;
        VectorString = vectorString;
    }    

}