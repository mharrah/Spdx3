using System.Text.Json.Serialization;
using Spdx3.Serialization;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A key with an associated value.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/DictionaryEntry/
/// </summary>
public class DictionaryEntry : BaseSpdxClass
{
    [JsonPropertyName("key")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Value { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Key));
    }

    internal DictionaryEntry()
    {
    }
}