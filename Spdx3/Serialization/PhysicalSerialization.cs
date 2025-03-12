using System.Text.Json.Serialization;
using Spdx3.Model;
using Spdx3.Utility;

namespace Spdx3.Serialization;

/// <summary>
///     A wrapper class for the contents of the catalog
/// </summary>
public class PhysicalSerialization
{
    [JsonPropertyName("@context")]
    [JsonConverter(typeof(SpdxWrapperConverterFactory))]
    public string Path { get; } = "https://spdx.github.io/spdx-spec/v3.0.1/rdf/spdx-context.jsonld";

    [JsonPropertyName("@graph")]
    [JsonConverter(typeof(SpdxWrapperConverterFactory))]
    public IList<BaseModelClass> Graph { get; } = new List<BaseModelClass>();

    public PhysicalSerialization(Catalog catalog)
    {
        Graph = catalog.Items.Values.ToList();
    }

    public PhysicalSerialization()
    {
    }
}