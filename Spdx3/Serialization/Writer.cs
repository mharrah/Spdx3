using System.Text.Json;
using Spdx3.Utility;

namespace Spdx3.Serialization;

public class Writer
{
    /// <summary>
    ///     The catalog we're writing out
    /// </summary>
    private readonly Catalog _catalog;

    /// <summary>
    ///     Serialization options
    /// </summary>
    private JsonSerializerOptions Options { get; } = new()
    {
        WriteIndented = false,
        MaxDepth = 99
    };

    /// <summary>
    ///     Constructor
    /// </summary>
    /// <param name="catalog">The catalog of objects to write</param>
    public Writer(Catalog catalog)
    {
        _catalog = catalog;
        Options.Converters.Add(new SpdxModelConverterFactory());
        Options.Converters.Add(new SpdxWrapperConverterFactory());
    }

    /// <summary>
    ///     Write the catalog to a string that is the content of an SPDX 3.0.1 compliant JSON file.
    /// </summary>
    /// <returns>The catalog as a string</returns>
    public string Write()
    {
        // ReSharper disable once SuggestVarOrType_BuiltInTypes
        object obj = new PhysicalSerialization(_catalog);
        // ReSharper disable once RedundantTypeArgumentsOfMethod
        var result = JsonSerializer.Serialize<object>(obj, Options);

        return result;
    }

    /// <summary>
    ///     Write the catalog to an SPDX 3.0.1 compliant JSON file
    /// </summary>
    /// <param name="fileStream">The FileStream to write to</param>
    /// <returns>The file we wrote to</returns>
    public FileStream Write(FileStream fileStream)
    {
        using var writer = new StreamWriter(fileStream);
        writer.Write(Write());
        return fileStream;
    }

    /// <summary>
    ///     Create a new file and write the catalog to it as SPDX 3.0.1 compliant JSON
    /// </summary>
    /// <param name="fileName">The name of the new JSON file to create</param>
    /// <param name="catalog">The catalog of objects to write</param>
    /// <returns>The file we created and wrote to</returns>
    public FileStream Write(string fileName)
    {
        var fileStream = new FileStream(fileName, FileMode.Create);
        Write(fileStream);
        return fileStream;
    }
}