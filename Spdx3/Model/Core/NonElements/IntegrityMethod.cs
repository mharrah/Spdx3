using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     An independently reproducible mechanism that permits verification of a specific Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/IntegrityMethod/
/// </summary>
public abstract class IntegrityMethod : BaseSpdxClass
{
    [SetsRequiredMembers]
    protected IntegrityMethod(SpdxIdFactory spdxIdFactory) : base(spdxIdFactory)
    {
    }

    [JsonPropertyName("comment")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Comment { get; set; }
}