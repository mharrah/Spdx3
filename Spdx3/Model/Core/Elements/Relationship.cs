using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

public class Relationship : Element
{
    [SetsRequiredMembers]
    public Relationship(ISpdxIdFactory idFactory, CreationInfo creationInfo, RelationshipType relationshipType,
        Element fromElement, List<Element> toElements) : base(idFactory, "Relationship", creationInfo)
    {
        RelationshipType = relationshipType;
        FromElementSpdxId = fromElement.SpdxId;
        toElements.ForEach(e => ToElementSpdxId.Add(e.SpdxId));
    }

    [JsonPropertyName("relationshipType")]
    public RelationshipType RelationshipType { get; set; }

    [JsonPropertyName("completeness")]
    public RelationshipCompleteness? Completeness { get; set; }

    [JsonPropertyName("startTime")]
    public DateTimeOffset? StartTime { get; set; }

    [JsonPropertyName("endTime")]
    public DateTimeOffset? EndTime { get; set; }

    [JsonPropertyName("from")]
    public string FromElementSpdxId { get; set; }

    [JsonPropertyName("to")]
    public IList<string> ToElementSpdxId { get; } = new List<string>();
}