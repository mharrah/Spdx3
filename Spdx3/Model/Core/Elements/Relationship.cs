using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Enums;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     Describes a relationship between one or more elements.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Relationship/
/// </summary>
public class Relationship : Element
{
    [JsonPropertyName("from")]
    public string? FromRef { get; set; }

    [JsonPropertyName("to")]
    public IList<string> ToRef { get; set; } = new List<string>();

    [JsonPropertyName("relationshipType")]
    public RelationshipType? RelationshipType { get; set; }

    [JsonPropertyName("completeness")]
    public RelationshipCompleteness? Completeness { get; set; }

    [JsonPropertyName("startTime")]
    public DateTimeOffset? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public DateTimeOffset? EndTime { get; set; }

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(FromRef));
        if (ToRef.Count == 0) throw new Spdx3ValidationException(this, nameof(ToRef), "Cannot be empty");
        ValidateRequiredProperty(nameof(RelationshipType));
    }
}