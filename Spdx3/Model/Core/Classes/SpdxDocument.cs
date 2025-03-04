using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A collection of SPDX Elements that could potentially be serialized.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/SpdxDocument/
/// </summary>
public class SpdxDocument : ElementCollection
{
    [SetsRequiredMembers]
    public SpdxDocument(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
    }

    [JsonPropertyName("import")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<ExternalMap> Import { get; } = new List<ExternalMap>();

    [JsonPropertyName("dataLicense")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public AnyLicenseInfo? DataLicense { get; set; }

    [JsonPropertyName("namespaceMap")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<NamespaceMap> NamespaceMap { get; } = new List<NamespaceMap>();
}