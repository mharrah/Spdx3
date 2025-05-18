# Spdx3

### A NuGet library (.NET 8) for creating, reading, and writing [Software Bills of Materials](https://www.ntia.gov/page/software-bill-materials) files in [SPDX 3](https://spdx.github.io/spdx-spec/v3.0.1/) format.

## Table of Contents
- [Description](#description)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

---
# Description

SPDX3 is NuGet library (.NET 8) for creating, reading, and writing [Software Bills of Materials](https://www.ntia.gov/page/software-bill-materials) files in [SPDX 3](https://spdx.github.io/spdx-spec/v3.0.1/) format.

> [!NOTE]
> SPDX3 is primarily intended for tool-writers who want to create their own SBOMs directly and want a compliant data model and serialization utilities to do that.  
> It's not a utility/tool for inspecting artifacts, deriving SBOM material, or otherwise generating SBOMs for things.
> However, you can write code do to that inspection/derivation/generation and use this library to hold, serialize, and deserialize the data.

This library provides:
- A C# object model for the entire [SPDX3 spec](https://spdx.github.io/spdx-spec/v3.0.1/annexes/rdf-model/) 
- Serialization and deserialization to/from JSON-LD format
- Validation
- Checking for [Lite domain](https://spdx.github.io/spdx-spec/v3.0.1/model/Lite/Lite/) compliance
- A full list of pre-created ```ListedLicense``` objects that correspond to the [SPDX License List](https://spdx.org/licenses/)

# Installation
Install into your project like you would any other NuGet package, and set up a project dependency.
See [here](https://learn.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-using-the-dotnet-cli) for more.

# Usage

## Create a new SBOM from scratch
The idea is that you need to do the following:
1. Create a ```Catalog``` object
2. Create a ```CreationInfo``` object
3. Start making objects, passing the ```Catalog``` and ```CreationInfo``` object on the constructors.  The most important of these objects to create is an ```SpdxDocument``` object, which is the highest-level object in the catalog. There needs to be exactly one ```SpdxDocument``` in any valid SPDX document file. 
4. Add those objects to the appropriate places in the collections on the objects.  This is all dependent on the content that you want to create.

```csharp
using Spdx3.Model.Core.Classes;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Utility;

namespace Examples;

public class Example1CreateNewSpdxDocument
{
    public void CreateNewSpdxDocumentWithSbom()
    {
        var catalog = new Catalog();
        var creationInfo = new CreationInfo(catalog);
        
        // Every SPDX file needs to have one and only one SpdxDocument element, so make that first.
        // Pass the catalog and creationInfo object to the constructor.
        var spdxDocument = new SpdxDocument(catalog, creationInfo)
        {
            Comment = "This is my new Spdx document.",
            Description = "This is an example of how to create a new SPDX document and put an SBOM in it.",
            Name = "Example1",
            Summary = "This is a sample SPDX document.",
            DataLicense = ListedLicenses.MIT
        };
        
        // Make a new SBOM object (which adds it to the catalog) and add it to the SpdxDocument
        var sbom = new Sbom(catalog, creationInfo);
        spdxDocument.Element.Add(sbom);

        // Add items like subclasses of Element to the SBOM (most likely to the Element or Relationship lists)
        var org = new Organization(catalog, creationInfo);
        sbom.Element.Add(org);
        
        // Etc.
    }
}
```
It's highly recommended that you ***not*** make changes to the values of the ```SpdxId``` or 
```Type``` properties on any object unless you know for sure what you're doing.

## Reading an SPDX document from a file
To read an SPDX file, you create a catalog to hold its contents, read the file, then start working with the contents
(the starting point being the unique ```SpdxDocument``` object from the file).
```csharp
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
```
## Writing an SPDX document to a file
Once you have a catalog that contains one and only one ```SpdxDocument``` object (along with all the others),
create a ```Writer``` for the catalog and write its contents to a file.
```csharp
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
```



# Contributing
If you would like to contribute to SPDX 3, email me at ```github``` at ```mharrah.simplelogin.com```.

# License
SPDX 3 is released under the [MIT License](https://github.com/mharrah/Spdx3/blob/main/LICENSE).



