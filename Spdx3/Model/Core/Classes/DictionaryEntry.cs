using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A key with an associated value.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/DictionaryEntry/
/// </summary>
public class DictionaryEntry : BaseSpdxClass
{
    [SetsRequiredMembers]
    public DictionaryEntry(SpdxIdFactory spdxIdFactory, string key) : base(spdxIdFactory)
    {
        Key = key;
    }

    [SetsRequiredMembers]
    public DictionaryEntry(SpdxIdFactory spdxIdFactory, string key, string? value) : this(spdxIdFactory, key)
    {
        Value = value;
    }

    [JsonPropertyName("key")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public string? Value { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Key));
    }
}