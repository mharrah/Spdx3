using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     A collection of SPDX Elements that could potentially be serialized.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/SpdxDocument/
/// </summary>
public class SpdxDocument() : ElementCollection
{
    [JsonPropertyName("import")]
    public IList<ExternalMap> Import { get; } = new List<ExternalMap>();

    [JsonPropertyName("dataLicense")]
    public string? DataLicenseRef { get; set; }

    [JsonPropertyName("namespaceMap")]
    public IList<NamespaceMap> NamespaceMap { get; } = new List<NamespaceMap>();
}