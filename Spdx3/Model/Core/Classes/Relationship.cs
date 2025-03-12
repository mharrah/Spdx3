using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     Describes a relationship between one or more elements.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Relationship/
/// </summary>
public class Relationship : Element
{
    [JsonPropertyName("from")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required Element From { get; set; }

    [JsonPropertyName("to")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<Element> To { get; set; }

    [JsonPropertyName("relationshipType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required RelationshipType RelationshipType { get; set; }

    [JsonPropertyName("completeness")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public RelationshipCompleteness? Completeness { get; set; }

    [JsonPropertyName("startTime")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public DateTimeOffset? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public DateTimeOffset? EndTime { get; set; }

    // protected internal no-parm constructor required for deserialization
    protected internal Relationship()
    {
    }


    /// <summary>
    ///     Describes a relationship between one or more elements.
    ///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Relationship/
    /// </summary>
    [method: SetsRequiredMembers]
    public Relationship(Catalog catalog,
        CreationInfo creationInfo,
        RelationshipType relationshipType,
        Element from,
        List<Element> to) : base(catalog, creationInfo)
    {
        From = from;
        To = to;
        RelationshipType = relationshipType;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(From));
        if (To.Count == 0)
        {
            throw new Spdx3ValidationException(this, nameof(To), "Cannot be empty");
        }

        ValidateRequiredProperty(nameof(RelationshipType));
    }
}