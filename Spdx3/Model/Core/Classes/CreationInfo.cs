using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     Provides information about the creation of the Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/CreationInfo/
/// </summary>
public class CreationInfo : BaseModelClass
{
    [JsonPropertyName("createdBy")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<Agent> CreatedBy { get; } = new List<Agent>();

    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? Comment { get; set; }

    [JsonPropertyName("created")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required DateTimeOffset Created { get; set; }

    [JsonPropertyName("createdUsing")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public IList<Tool> CreatedUsing { get; } = new List<Tool>();

    [JsonPropertyName("specVersion")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string SpecVersion { get; set; } = "3.0.1";

    // protected internal no-parm constructor required for deserialization
    protected internal CreationInfo()
    {
    }

    [SetsRequiredMembers]
    public CreationInfo(Catalog catalog) : base(catalog)
    {
        Created = DateTimeOffset.UtcNow;
    }

    [SetsRequiredMembers]
    public CreationInfo(Catalog catalog, DateTimeOffset created) : base(catalog)
    {
        Created = created;
    }
}