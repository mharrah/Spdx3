using System.Text.Json.Serialization;

namespace Spdx3.Model;

public interface ISpdxClass
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("spdxId")]
    public string SpdxId { get; set; }
}