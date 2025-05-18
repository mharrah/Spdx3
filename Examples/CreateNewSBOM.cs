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

        var spdxDocument = new SpdxDocument(catalog, creationInfo)
        {
            Comment = "This is my new Spdx document.",
            Description = "This is an example of how to create a new SPDX document and put an SBOM in it.",
            Name = "Example1",
            Summary = "This is a sample SPDX document.",
            DataLicense = ListedLicenses.MIT
        };
        var sbom = new Sbom(catalog, creationInfo);
        spdxDocument.Element.Add(sbom);

        // Add items to the sbom (most likely to the Element or Relationship lists) 
    }
}