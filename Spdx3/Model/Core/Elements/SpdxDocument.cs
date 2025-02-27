using System.ComponentModel;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.NonElements;
using Spdx3.Serialization;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     A collection of SPDX Elements that could potentially be serialized.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/SpdxDocument/
/// </summary>
public class SpdxDocument : ElementCollection
{
    [JsonPropertyName("import")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<ExternalMap> Import { get; } = new List<ExternalMap>();

    [JsonPropertyName("dataLicense")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public License? DataLicense { get; set; }

    [JsonPropertyName("namespaceMap")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<NamespaceMap> NamespaceMap { get; } = new List<NamespaceMap>();

    internal SpdxDocument()
    {
    }
}