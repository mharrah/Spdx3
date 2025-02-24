using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Tests.Model.Core.Elements;

namespace Spdx3.Model.Core.Elements;

/// <summary>
/// 
/// </summary>
public class LifecycleScopedRelationship : Relationship
{
    [JsonPropertyName("scope")]
    public LifecycleScopeType? Scope { get; set; }
}