using System.Text.Json.Serialization;

namespace Spdx3.Model.Core.NonElements;

/// <summary>
///     A key with an associated value.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/DictionaryEntry/
/// </summary>
public class DictionaryEntry : BaseSpdxClass
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    public new void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Key));
    }

    internal DictionaryEntry()
    {
        
    }
}