using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A collection of Elements, not necessarily with unifying context.  An intermediate (abstract/base) class.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/ElementCollection/
/// </summary>
public abstract class ElementCollection : Element
{
    [JsonPropertyName("profileConformance")]
    public IList<ProfileIdentifierType> ProfileConformance { get; } = new List<ProfileIdentifierType>();

    /// <summary>
    ///     Yep, the spec says zero to many root elements. Go figure.
    /// </summary>
    [JsonPropertyName("rootElement")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<Element> RootElement { get; } = new List<Element>();

    [JsonPropertyName("element")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<Element> Element { get; } = new List<Element>();

    // protected internal no-parm constructor required for deserialization
    protected internal ElementCollection()
    {
    }


    [SetsRequiredMembers]
    protected ElementCollection(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}