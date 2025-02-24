using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     A distinct article or unit within the digital domain.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Artifact/
/// </summary>
public abstract class Artifact() : Element
{
    [JsonPropertyName("builtTime")]
    public DateTimeOffset? BuiltTime { get; set; }
    
    [JsonPropertyName("originatedBy")]
    public IList<string> OriginatedByAgentRef { get; set; } = new List<string>();
    
    [JsonPropertyName("releaseTime")]
    public DateTimeOffset? ReleaseTime { get; set; }
    
    [JsonPropertyName("standardName")]
    public string? StandardName { get; set; }
    
    [JsonPropertyName("suppliedBy")]
    public string? SuppliedByAgentRef { get; set; }
    
    [JsonPropertyName("supportLevel")]
    public IList<SupportType> SupportLevel { get; set; } = new List<SupportType>();
    
    [JsonPropertyName("validUntilTime")]
    public DateTimeOffset? ValidUntilTime { get; set; }


}