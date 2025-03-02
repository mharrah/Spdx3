using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Elements;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     Provides information about the creation of the Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/CreationInfo/
/// </summary>
public class CreationInfo : BaseSpdxClass
{
    [SetsRequiredMembers]
    public CreationInfo(SpdxIdFactory spdxIdFactory) : base(spdxIdFactory)
    {
        Created = DateTimeOffset.UtcNow;
    }

    [SetsRequiredMembers]
    public CreationInfo(SpdxIdFactory spdxIdFactory, DateTimeOffset created) : base(spdxIdFactory)
    {
        Created = created;
    }

    [JsonPropertyName("createdBy")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Agent> CreatedBy { get; } = new List<Agent>();

    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Comment { get; set; }

    [JsonPropertyName("created")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required DateTimeOffset Created { get; set; }

    [JsonPropertyName("createdUsing")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Tool> CreatedUsing { get; } = new List<Tool>();

    [JsonPropertyName("specVersion")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string SpecVersion { get; set; } = "3.0.1";
}