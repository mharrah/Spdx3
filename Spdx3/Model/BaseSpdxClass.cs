using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model;

/// <summary>
///     This is a base class for like EVERYthing in an SPDX document, whether it's an "Element" or some other "Non-Element"
///     class.
///     See https://spdx.github.io/spdx-spec/v3.0.1/annexes/rdf-model/
/// </summary>
public abstract class BaseSpdxClass
{
    private static readonly JsonSerializerOptions Options = new()
    {
        WriteIndented = true,
        TypeInfoResolver = new DefaultJsonTypeInfoResolver
        {
            Modifiers = { IgnoreEmptyCollections.Modifier }
        }
    };

    [SetsRequiredMembers]
    protected BaseSpdxClass(ISpdxIdFactory idFactory, string classType)
    {
        Type = classType;
        SpdxId = idFactory.New(Type);
    }

    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("spdxId")]
    public required string SpdxId { get; init; }

    /// <summary>
    ///     A little syntactic sugar.  Returns the object as a JSON string, with the sort of formatting that's typical/expected
    ///     for SPDX files.
    /// </summary>
    /// <returns>A Json representation of this object</returns>
    public string ToJson()
    {
        // This ridiculous looking cast is REQUIRED to get serialization to do the polymorphic thing properly.
        // If you don't cast it like this, only the base class properties will be serialized by JsonSerializer, and that's (clearly) not ok.
        return JsonSerializer.Serialize<object>(this, Options);
    }
}