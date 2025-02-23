using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model;

public interface ISpdxClass
{
    [JsonPropertyName("type")]
    public string Type { get; internal set; }

    [JsonPropertyName("spdxId")]
    public string SpdxId { get; internal set; }
    
    
    /// <summary>Returns the object as a JSON string, with the sort of formatting that's typical/expected for SPDX files.</summary>
    /// <returns>A Json representation of this object</returns>
    public string ToJson();
}