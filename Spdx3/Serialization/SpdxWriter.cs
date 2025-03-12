using System.Text.Json;
using Spdx3.Utility;

namespace Spdx3.Serialization;

public class SpdxWriter
{
    // TODO implement

    /// <summary>
    ///     Serialization options
    /// </summary>
    private JsonSerializerOptions Options { get; } = new()
    {
        WriteIndented = false,
        MaxDepth = 2
    };

    public SpdxWriter()
    {
        Options.Converters.Add(new SpdxObjectConverterFactory());
    }
    
    /// <summary>
    /// Write the catalog to a string that is the content of an SPDX 3.0.1 compliant JSON file.
    /// </summary>
    /// <param name="catalog">The catalog of objects to write</param>
    /// <returns>The catalog as as string</returns>
    public string Write(SpdxCatalog catalog)
    {
        // ReSharper disable once SuggestVarOrType_BuiltInTypes
        object o = this;
        // ReSharper disable once RedundantTypeArgumentsOfMethod
        var result = JsonSerializer.Serialize<object>(o, Options);
        
        return result;
    }

    /// <summary>
    /// Write the catalog to an SPDX 3.0.1 compliant JSON file 
    /// </summary>
    /// <param name="fileStream">The FileStream to write to</param>
    /// <param name="catalog">The catalog of objects to write</param>
    /// <returns>The file we wrote to</returns>
    public FileStream Write(FileStream fileStream, SpdxCatalog catalog)
    {
        using var writer = new StreamWriter(fileStream);
        writer.Write(Write(catalog));
        return fileStream;
    }
    
    /// <summary>
    /// Create a new file and write the catalog to it as SPDX 3.0.1 compliant JSON 
    /// </summary>
    /// <param name="fileName">The name of the new JSON file to create</param>
    /// <param name="catalog">The catalog of objects to write</param>
    /// <returns>The file we created and wrote to</returns>
    public FileStream Write(string fileName, SpdxCatalog catalog)
    {
        var fileStream = new FileStream(fileName, FileMode.Create);
        Write(fileStream, catalog);
        return fileStream;
    }
}