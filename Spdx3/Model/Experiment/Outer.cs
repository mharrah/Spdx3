using System.Text.Json.Serialization;
using Spdx3.Serialization;

namespace Spdx3.Model.Experiment;

public class Outer : BaseSpdxClass
{
 
    [JsonPropertyName("middles")]
    [JsonConverter(typeof(SpdxCollectionConvertorFactory))]
    public IList<Middle> Middles { get; } = new List<Middle>();
    
    [JsonPropertyName("empty")]
    [JsonConverter(typeof(SpdxCollectionConvertorFactory))]
    public IList<Inner> Empty { get;  } = new List<Inner>();

    [JsonPropertyName("comment")]
    public string Comment { get; set; } = "Outer comment";
        
    internal Outer()
    {
    }
}