using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Security.Classes;

/// <summary>
/// Provides an EPSS assessment for a vulnerability.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Security/Classes/EpssVulnAssessmentRelationship/
/// </summary>
public class EpssVulnAssessmentRelationship : VulnAssessmentRelationship
{
    private double _percentile;
    private double _probability;

    [JsonPropertyName("security_percentile")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required double Percentile
    {
        get => _percentile;
        set
        {
            if (value is < 0.0 or > 1.0)
            {
                throw new Spdx3Exception("Illegal value for Percentile",
                    new ArgumentException("The value must be between 0.0 and 1.0 (inclusive)"));
            }
            _percentile = value;
        }
    }

    [JsonPropertyName("security_probability")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required double Probability
    {
        get => _probability;
        set
        {
            if (value is < 0.0 or > 1.0)
            {
                throw new Spdx3Exception("Illegal value for Probability",
                    new ArgumentException("The value must be between 0.0 and 1.0 (inclusive)"));
            }
            _probability = value;
        }
    }

    // protected internal no-parm constructor required for deserialization
#pragma warning disable CS8618, CS9264
    protected internal EpssVulnAssessmentRelationship()
    {
    }
#pragma warning restore CS8618, CS9264

    [SetsRequiredMembers]
    public EpssVulnAssessmentRelationship(Catalog catalog, CreationInfo creationInfo, Element from, List<Element> to,
        double percentile, double probability) : base(catalog, creationInfo, RelationshipType.hasAssessmentFor, from,
        to)
    {
        Percentile = percentile;
        Probability = probability;
    }
}