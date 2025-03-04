using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A distinct article or unit within the digital domain.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Artifact/
/// </summary>
public abstract class Artifact : Element
{
    [SetsRequiredMembers]
    protected Artifact(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
    }

    [JsonPropertyName("builtTime")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public DateTimeOffset? BuiltTime { get; set; }

    [JsonPropertyName("originatedBy")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Agent> OriginatedBy { get; set; } = new List<Agent>();

    [JsonPropertyName("releaseTime")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public DateTimeOffset? ReleaseTime { get; set; }

    [JsonPropertyName("standardName")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? StandardName { get; set; }

    [JsonPropertyName("suppliedBy")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public Agent? SuppliedBy { get; set; }

    [JsonPropertyName("supportLevel")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<SupportType> SupportLevel { get; set; } = new List<SupportType>();

    [JsonPropertyName("validUntilTime")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public DateTimeOffset? ValidUntilTime { get; set; }
}