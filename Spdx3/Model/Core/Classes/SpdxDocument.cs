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
    [JsonPropertyName("import")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<ExternalMap> Import { get; } = new List<ExternalMap>();

    [JsonPropertyName("dataLicense")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public AnyLicenseInfo? DataLicense { get; set; }

    [JsonPropertyName("namespaceMap")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<NamespaceMap> NamespaceMap { get; } = new List<NamespaceMap>();

    // protected internal no-parm constructor required for deserialization
    protected internal SpdxDocument()
    {
    }

    [SetsRequiredMembers]
    public SpdxDocument(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}