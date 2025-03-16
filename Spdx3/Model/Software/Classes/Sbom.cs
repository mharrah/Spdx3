using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Software.Classes;

public class Sbom : Bom
{
    [JsonPropertyName("software_sbomType")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<SbomType> SbomType { get; } = new List<SbomType>();

    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal Sbom()
    {
    }

    [SetsRequiredMembers]
    public Sbom(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}