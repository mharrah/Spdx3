using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     A collection of Elements that have a shared context.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Bundle/
/// </summary>
public class Bundle : ElementCollection
{
    [JsonPropertyName("context")]
    public IList<string> Context { get; } = new List<string>();

    internal Bundle()
    {
        
    }
}