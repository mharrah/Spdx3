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