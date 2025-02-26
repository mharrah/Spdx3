using System.Text.Json.Serialization;

namespace Spdx3.Model.Experiment;

public class Inner : BaseSpdxClass
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = "Some test text";

    internal Inner()
    {
    }

}