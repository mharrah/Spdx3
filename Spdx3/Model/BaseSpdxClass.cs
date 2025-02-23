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
public abstract class BaseSpdxClass : ISpdxClass
{
    [JsonIgnore]
    public SpdxClassFactory? CreatedByFactory { get; set; }
    
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("spdxId")]
    public string SpdxId { get; set; } = string.Empty;

    /// <summary>
    /// Serialization options
    /// </summary>
    private static readonly JsonSerializerOptions Options = new()
    {
        WriteIndented = true,
        TypeInfoResolver = new DefaultJsonTypeInfoResolver
        {
            Modifiers = { IgnoreEmptyCollections.Modifier }
        }
    };
    
    /// <summary>
    ///     A little syntactic sugar.  Returns the object as a JSON string, with the sort of formatting that's typical/expected
    ///     for SPDX files.
    /// </summary>
    /// <returns>A Json representation of this object</returns>
    public string ToJson()
    {
        // This ridiculous looking cast is REQUIRED to get serialization to do the polymorphic thing properly.
        // If you don't cast it like this, only the base class properties will be serialized by JsonSerializer,
        // and that's (clearly) not ok.
        
        // ReSharper disable once SuggestVarOrType_BuiltInTypes
        object o = (object)this;
        return JsonSerializer.Serialize<object>(o, Options);
    }
}
