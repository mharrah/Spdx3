using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     An independently reproducible mechanism that permits verification of a specific Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/IntegrityMethod/
/// </summary>
public abstract class IntegrityMethod : BaseModelClass
{
    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? Comment { get; set; }

    // protected internal no-parm constructor required for deserialization
    protected internal IntegrityMethod()
    {
    }

    [SetsRequiredMembers]
    protected IntegrityMethod(Catalog catalog) : base(catalog)
    {
    }
}