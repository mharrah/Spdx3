using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.RegularExpressions;
using Spdx3.Model;
using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Spdx3.Tests.Model;

/// <summary>
///     Base class for all tests of SpdxClass (and its subclasses). Has convenience methods to keep things predictable and
///     less repetitive.
/// </summary>
[SuppressMessage("Performance", "SYSLIB1045:Convert to \'GeneratedRegexAttribute\'.")]
public class BaseModelTest
{
    // What the name says - a predictable datetimeoffset value
    protected static readonly DateTimeOffset PredictableDateTime = new(2025, 02, 22, 1, 23, 45, TimeSpan.Zero);

    // A premade SpdxCatalog to use. Always start the catalog id counter at the same value so ID's are predictable.
    protected Catalog TestCatalog { get; } = new(1000);

    // A premade CreationInfo object to use
    protected CreationInfo TestCreationInfo { get; }

    /// <summary>
    ///     Serialization options
    /// </summary>
    private JsonSerializerOptions Options { get; } = new()
    {
        WriteIndented = true,
        MaxDepth = 2
    };


    // Constructor
    protected BaseModelTest()
    {
        TestCreationInfo = new CreationInfo(TestCatalog, PredictableDateTime);
        TestCreationInfo.CreatedBy.Add(new SoftwareAgent(TestCatalog, TestCreationInfo)
            { Name = $"{nameof(BaseModelTest)} constructor" });
        Options.Converters.Add(new SpdxModelConverterFactory());
    }

    /// <summary>
    ///     Convenience method to remove line breaks and all whitespace at the beginning and end of the line breaks.
    ///     This makes it easy to use here-strings for JSON literals without having to use ugly escapes and have
    ///     weird, opaque line wrapping.
    /// </summary>
    /// <param name="json">The json you want to normalize</param>
    /// <returns>The json with leading/trailing spaces removed on each line, and the line breaks removed as well</returns>
    protected static string NormalizeJson(string json)
    {
        var result = Regex.Replace(json, @"^\s*", "", RegexOptions.Multiline);
        result = Regex.Replace(result, @"\s*$", "", RegexOptions.Multiline);
        result = Regex.Replace(result, @"(\r|\n)", "", RegexOptions.Multiline);
        return result;
    }

    protected T? FromJson<T>(string json)
    {
        var result = JsonSerializer.Deserialize<T>(json, Options);
        return result;
    }

    /// <summary>
    ///     Syntactic sugar method for testing serialization.  Unlike the SpdxWriter class, this method produces
    ///     JSON that has line breaks and indents
    /// </summary>
    /// <returns>A Json representation of this object</returns>
    protected string ToJson(BaseModelClass obj)
    {
        // Validate the object
        obj.Validate();

        // This ridiculous looking cast is REQUIRED to get serialization to do the polymorphic thing properly.
        // If you don't cast it like this, only the base class properties will be serialized by JsonSerializer,
        // and that's (clearly) not ok.
        // ReSharper disable once CanReplaceCastWithVariableType
        // ReSharper disable once SuggestVarOrType_BuiltInTypes
        // ReSharper disable once RedundantCast
        object plainObject = (object)obj;
        // ReSharper disable once RedundantTypeArgumentsOfMethod
        return JsonSerializer.Serialize<object>(plainObject, Options);
    }
}