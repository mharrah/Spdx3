using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

public class Relationship : Element
{
    
    [JsonPropertyName("relationshipType")]
    public RelationshipType RelationshipType { get; set; }

    [JsonPropertyName("completeness")]
    public RelationshipCompleteness? Completeness { get; set; }

    [JsonPropertyName("startTime")]
    public DateTimeOffset? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public DateTimeOffset? EndTime { get; set; }

    [JsonPropertyName("from")]
    public string? FromElementSpdxId { get; set; }

    [JsonPropertyName("to")]
    public IList<string> ToElementSpdxId { get; } = new List<string>();
}