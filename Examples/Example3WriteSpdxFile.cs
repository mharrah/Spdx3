using Spdx3.Serialization;
using Spdx3.Utility;

namespace Examples;

public class Example3WriteSpdxFile
{
    public void WriteSpdxFile(Catalog catalog)
    {
        // Create a writer for the catalog
        var writer = new Writer(catalog);
        
        // Write the catalog contents out to the JSON file
        writer.WriteFileName("mySpdxDocument.json");
    }
}