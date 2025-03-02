using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Model.Core.NonElements;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     A collection of Elements, not necessarily with unifying context.  An intermediate (abstract/base) class.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ElementCollection/
/// </summary>
public abstract class ElementCollection : Element
{
    [SetsRequiredMembers]
    protected ElementCollection(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
    }

    [JsonPropertyName("profileConformance")]
    public IList<ProfileIdentifierType> ProfileConformance { get; } = new List<ProfileIdentifierType>();

    /// <summary>
    ///     Yep, the spec says zero to many root elements. Go figure.
    /// </summary>
    [JsonPropertyName("rootElement")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Element> RootElement { get; } = new List<Element>();

    [JsonPropertyName("element")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<Element> Element { get; } = new List<Element>();
}