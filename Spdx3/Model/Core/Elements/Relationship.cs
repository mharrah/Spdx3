using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     Describes a relationship between one or more elements.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Relationship/
/// </summary>
public class Relationship : Element
{
    [JsonPropertyName("from")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public Element? From { get; set; }

    [JsonPropertyName("to")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Element> To { get; init; } = new List<Element>();

    [JsonPropertyName("relationshipType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public RelationshipType? RelationshipType { get; set; }

    [JsonPropertyName("completeness")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public RelationshipCompleteness? Completeness { get; set; }

    [JsonPropertyName("startTime")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public DateTimeOffset? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public DateTimeOffset? EndTime { get; set; }

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(From));
        if (To.Count == 0)
        {
            throw new Spdx3ValidationException(this, nameof(To), "Cannot be empty");
        }

        ValidateRequiredProperty(nameof(RelationshipType));
    }

    internal Relationship()
    {
    }
}