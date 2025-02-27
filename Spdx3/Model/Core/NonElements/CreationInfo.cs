using System.Text.Json.Serialization;
using Spdx3.Model.Core.Elements;
using Spdx3.Serialization;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     Provides information about the creation of the Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/CreationInfo/
/// </summary>
public class CreationInfo : BaseSpdxClass
{
    [JsonPropertyName("createdBy")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Agent> CreatedBy { get; } = new List<Agent>();

    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Comment { get; set; }

    [JsonPropertyName("created")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public DateTimeOffset? Created { get; set; }

    [JsonPropertyName("createdUsing")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Tool> CreatedUsing { get; } = new List<Tool>();

    [JsonPropertyName("specVersion")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string SpecVersion { get; set; } = "3.0.1";

    internal CreationInfo()
    {
    }
}