using System.Text.Json;
using Spdx3.Exceptions;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Serialization;

public class Reader
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
    public Reader(Catalog catalog)
    {
        _catalog = catalog;
        Options.Converters.Add(new SpdxModelConverterFactory());
        Options.Converters.Add(new SpdxWrapperConverterFactory());
    }

    public SpdxDocument ReadString(string json)
    {
        var fileWithWrapper = JsonSerializer.Deserialize<SpdxWrapper>(json, Options);
        if (fileWithWrapper == null)
        {
            throw new Spdx3SerializationException("Could not deserialize JSON in expected format.");
        }

        foreach (var entry in fileWithWrapper.Graph)
        {
            _catalog.Items[entry.SpdxId] = entry;
        }

        return _catalog.GetModel();
    }

    public SpdxDocument ReadFileStream(FileStream fileStream)
    {
        var json = new StreamReader(fileStream).ReadToEnd();
        return ReadString(json);
    }

    public SpdxDocument ReadFileName(string fileName)
    {
        var fileStream = new FileStream(fileName, FileMode.Open);
        return ReadFileStream(fileStream);
    }
}