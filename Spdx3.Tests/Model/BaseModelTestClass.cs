using System.Text.Json;
using Spdx3.Model;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Tests.Model;

/// <summary>
///     Base class for all tests of SpdxClass (and its subclasses). Has convenience methods to keep things predictable and
///     less repetitive.
/// </summary>
public class BaseModelTestClass
{
    // What the name says - a predictable datetimeoffset value
    protected static readonly DateTimeOffset PredictableDateTime = new(2025, 02, 22, 1, 23, 45, TimeSpan.Zero);

    // A premade CreationInfo object to use
    protected CreationInfo TestCreationInfo { get; }

    // A premade SpdxCatalog to use
    protected SpdxCatalog TestSpdxCatalog { get; } = new();

    /// <summary>
    ///     Serialization options
    /// </summary>
    private JsonSerializerOptions Options { get; } = new()
    {
        WriteIndented = true,
        MaxDepth = 2
    };

    
    // Constructor
    protected BaseModelTestClass()
    {
        TestCreationInfo = new CreationInfo(TestSpdxCatalog, PredictableDateTime);
        Options.Converters.Add(new SpdxObjectConverterFactory());
    }
    
    /// <summary>
    ///     Syntactic sugar method for testing serialization.  Unlike the SpdxWriter class, this method produces
    ///     JSON that has line breaks and indents
    /// </summary>
    /// <returns>A Json representation of this object</returns>
    protected string ToJson(BaseSpdxClass obj)
    {
        // Validate the object
        obj.Validate();

        // This ridiculous looking cast is REQUIRED to get serialization to do the polymorphic thing properly.
        // If you don't cast it like this, only the base class properties will be serialized by JsonSerializer,
        // and that's (clearly) not ok.
        // ReSharper disable once CanReplaceCastWithVariableType
        object plainObject = (object)obj;
        return JsonSerializer.Serialize<object>(plainObject, Options);
    }
    
    protected T? FromJson<T>(string json)
    {
        T? result = JsonSerializer.Deserialize<T>(json, Options);
        return result;
    }

}