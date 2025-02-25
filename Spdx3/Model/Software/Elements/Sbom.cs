using System.Text.Json.Serialization;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Software.Enums;

namespace Spdx3.Model.Software.Elements;

public class Sbom : Bom
{
    [JsonPropertyName("sbomType")]
    public IList<SbomType> SbomType { get; } = new List<SbomType>();
}