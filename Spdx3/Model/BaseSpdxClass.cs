using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using Spdx3.Exceptions;
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
    /// <summary>
    ///     Serialization options
    /// </summary>
    private static readonly JsonSerializerOptions Options = new()
    {
        WriteIndented = true,
        TypeInfoResolver = new DefaultJsonTypeInfoResolver
        {
            Modifiers = { IgnoreEmptyCollections.Modifier }
        }
    };

    [JsonIgnore]
    public SpdxClassFactory? CreatedByFactory { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("spdxId")]
    public string SpdxId { get; set; } = string.Empty;

    /// <summary>
    ///     A little syntactic sugar.  Returns the object as a JSON string, with the sort of formatting that's typical/expected
    ///     for SPDX files.
    /// </summary>
    /// <returns>A Json representation of this object</returns>
    public string ToJson()
    {
        Validate();
        // This ridiculous looking cast is REQUIRED to get serialization to do the polymorphic thing properly.
        // If you don't cast it like this, only the base class properties will be serialized by JsonSerializer,
        // and that's (clearly) not ok.

        // ReSharper disable once SuggestVarOrType_BuiltInTypes
        object o = this;
        // ReSharper disable once RedundantTypeArgumentsOfMethod
        return JsonSerializer.Serialize<object>(o, Options);
    }

    public void Validate()
    {
        ValidateRequiredProperty(nameof(SpdxId));
        ValidateRequiredProperty(nameof(Type));
    }

    protected void ValidateRequiredProperty(string propertyName)
    {
        var propVal = GetType().GetProperty(propertyName)?.GetValue(this);
        switch (propVal)
        {
            case null:
                throw new Spdx3ValidationException(this, propertyName, "Field is required");
            case string when propVal.ToString() == string.Empty:
                throw new Spdx3ValidationException(this, propertyName, "Field is empty");
        }
    }
}