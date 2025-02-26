using System.Text.Json.Serialization;
using Spdx3.Model;

namespace Spdx3.Tests.Model.Core.Experiment;

public class Inner : BaseSpdxClass
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = "Some test text";

    internal Inner()
    {
    }

}