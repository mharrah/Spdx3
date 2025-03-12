using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A relationship that occurs in the lifecycle.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/LifecycleScopedRelationship/
/// </summary>
public class LifecycleScopedRelationship : Relationship
{
    [JsonPropertyName("scope")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public LifecycleScopeType? Scope { get; set; }

    // protected internal no-parm constructor required for deserialization
    protected internal LifecycleScopedRelationship()
    {
    }

    [SetsRequiredMembers]
    public LifecycleScopedRelationship(Catalog catalog, CreationInfo creationInfo,
        RelationshipType relationshipType, Element from, List<Element> to) : base(catalog, creationInfo,
        relationshipType, from, to)
    {
    }
}