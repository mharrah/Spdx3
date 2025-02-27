using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     A collection of Elements, not necessarily with unifying context.  An intermediate (abstract/base) class.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ElementCollection/
/// </summary>
public abstract class ElementCollection : Element
{
    [JsonPropertyName("profileConformance")]
    public IList<ProfileIdentifierType> ProfileConformance { get; } = new List<ProfileIdentifierType>();

    /// <summary>
    ///     Yep, the spec says one to many root elements. Go figure.
    /// </summary>
    [JsonPropertyName("rootElement")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Element> RootElement { get; } = new List<Element>();

    [JsonPropertyName("element")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Element> Element { get; } = new List<Element>();

    protected internal ElementCollection()
    {
    }
}