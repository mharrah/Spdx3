using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     An independently reproducible mechanism that permits verification of a specific Element.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/IntegrityMethod/
/// </summary>
public abstract class IntegrityMethod : BaseSpdxClass
{
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}