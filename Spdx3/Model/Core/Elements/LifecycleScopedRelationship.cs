using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;

namespace Spdx3.Model.Core.Elements;

/// <summary>
/// A relationship that occurs in the lifecycle.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/LifecycleScopedRelationship/
/// </summary>
public class LifecycleScopedRelationship : Relationship
{
    [JsonPropertyName("scope")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public LifecycleScopeType? Scope { get; set; }

    internal LifecycleScopedRelationship()
    {
    }
}