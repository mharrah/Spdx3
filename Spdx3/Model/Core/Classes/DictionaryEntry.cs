using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Spdx3.Serialization;
using Spdx3.Utility;

// ReSharper disable UnusedMember.Global

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A key with an associated value.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/DictionaryEntry/
/// </summary>
public class DictionaryEntry : BaseModelClass
{
    [JsonPropertyName("key")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    [JsonConverter(typeof(SpdxModelConverterFactory))]
    public string? Value { get; set; }

    // protected internal no-parm constructor required for deserialization
    protected internal DictionaryEntry()
    {
    }

    [SetsRequiredMembers]
    public DictionaryEntry(Catalog catalog, string key) : base(catalog)
    {
        Key = key;
    }

    [SetsRequiredMembers]
    public DictionaryEntry(Catalog catalog, string key, string? value) : this(catalog, key)
    {
        Value = value;
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(Key));
    }
}