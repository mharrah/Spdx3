using System.Text.Json.Serialization;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Software.Enums;
using Spdx3.Serialization;

namespace Spdx3.Model.Software.Elements;

public class Sbom : Bom
{
    [JsonPropertyName("sbomType")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public IList<SbomType> SbomType { get; } = new List<SbomType>();

    internal Sbom()
    {
    }
}