using Spdx3.Model.Core.Classes;
using Spdx3.Serialization;
using Spdx3.Utility;

namespace Examples;

public class Example2ReadSpdxFile
{
    public SpdxDocument GetSpdxDocumentFromFile()
    {
        // Start with Catalog to hold all the objects read from the json file
        var catalog = new Catalog();

        // Make a reader for the catalog
        var reader = new Reader(catalog);

        // Read the file and return the single, required SpdxDocument object that needs to be in there to be
        // a valid file.  The catalog contains everything in a flat dictionary format, but the SpdxDocument 
        // object contains a full object graph with references between objects.
        var spdxDocument = reader.ReadFileName("Acme Application.spdx3.0.1.json");

        return spdxDocument;
    }
}