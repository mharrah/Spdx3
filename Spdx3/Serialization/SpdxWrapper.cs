using System.Text.Json.Serialization;
using Spdx3.Model;
using Spdx3.Utility;

namespace Spdx3.Serialization;

/// <summary>
///     A wrapper class for the contents of the catalog. This is the top level object of a physical representation of SPDX data.
/// </summary>
internal class SpdxWrapper
{
    [JsonPropertyName("@context")]
    [JsonConverter(typeof(SpdxWrapperConverterFactory))]
    public static string Context => "https://spdx.org/rdf/3.0.1/spdx-context.jsonld";

    [JsonPropertyName("@graph")]
    [JsonConverter(typeof(SpdxWrapperConverterFactory))]
    public IList<BaseModelClass> Graph { get; } = new List<BaseModelClass>();

    public SpdxWrapper(Catalog catalog)
    {
        Graph = catalog.Items.Values.ToList();
    }

    public SpdxWrapper()
    {
    }
}