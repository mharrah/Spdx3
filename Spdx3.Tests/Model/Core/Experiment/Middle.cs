using System.Text.Json.Serialization;
using Spdx3.Model;

namespace Spdx3.Tests.Model.Core.Experiment;

public class Middle : BaseSpdxClass
{
    [JsonPropertyName("inners")]
    [JsonConverter(typeof(SpdxCollectionConvertorFactory))]
    public IList<Inner> Inners { get; } = new List<Inner>();
    
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; } = "My name";
    
    internal Middle()
    {
        Inners.Add(new Inner());
        Inners.Add(new Inner());
        Inners.Add(new Inner());
    }
}