using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using Spdx3.Exceptions;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Model;

/// <summary>
///     This is a base class for like EVERYTHING in an SPDX document, whether it's an "Element" or some other "Non-Element"
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
        MaxDepth = 2
    };

    static BaseSpdxClass()
    {
        Options.Converters.Add(new SpdxObjectConverterFactory());
    }

    public static T? FromJson<T>(string json)
    {
        T? result = JsonSerializer.Deserialize<T>(json, Options);
        return result;
    }
    
    // protected internal no-parm constructor required for deserialization
    protected internal BaseSpdxClass()
    {
    }

    [SetsRequiredMembers]
    protected BaseSpdxClass(SpdxCatalog spdxCatalog)
    {
        Type = SpdxUtility.SpdxTypeForClass(GetType());
        SpdxId = spdxCatalog.NewId(GetType());
        spdxCatalog.Items[SpdxId] = this;
    }

    [JsonPropertyName("type")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string Type { get; set; }

    [JsonPropertyName("spdxId")]
    [JsonConverter(typeof(SpdxObjectConverterFactory))]
    public required string SpdxId { get; init; }

    /// <summary>
    ///     A little syntactic sugar.  Validates the object, and if ok, returns the object as a JSON string,
    ///     with the sort of formatting that's typical/expected for SPDX files.
    /// 
    ///     Note that this is not what is actually written to JSON files when the catalog is written to JSON.
    /// 
    ///     One major difference is that this method includes line breaks and indentation, where the output
    ///     for a well-formed SPDX 3.0.1 document is supposed to have no line breaks. 
    /// </summary>
    /// <returns>A Json representation of this object</returns>
    public string ToJson()
    {
        // Validate the object
        Validate();

        // This ridiculous looking cast is REQUIRED to get serialization to do the polymorphic thing properly.
        // If you don't cast it like this, only the base class properties will be serialized by JsonSerializer,
        // and that's (clearly) not ok.

        // ReSharper disable once SuggestVarOrType_BuiltInTypes
        object o = this;
        // ReSharper disable once RedundantTypeArgumentsOfMethod
        return JsonSerializer.Serialize<object>(o, Options);
    }
    

    
    public virtual void Validate()
    {
        ValidateRequiredProperty(nameof(SpdxId));
        ValidateRequiredProperty(nameof(Type));
    }

    protected void ValidateRequiredProperty(string propertyName)
    {
        var propertyInfo = GetType().GetProperty(propertyName);
        if (propertyInfo == null)
        {
            throw new Spdx3ValidationException(this, $"'{propertyName}'", "No such property exists");
        }
        var propVal = propertyInfo.GetValue(this);
        if (propVal == null)
        {
            throw new Spdx3ValidationException(this, propertyName, "Field is required");
        }

        if (propVal is string && propVal.ToString() == string.Empty)
        {
            throw new Spdx3ValidationException(this, propertyName, "Field is empty");
        }
    }
}