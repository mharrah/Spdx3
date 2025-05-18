using Spdx3.Model.Core.Classes;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Model.ExpandedLicensing.Individuals;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Utility;

namespace Examples;

public class Example1_CreateNewSpdxDocument
{
    private readonly Catalog _catalog = new Catalog();
    
    private readonly CreationInfo _creationInfo;

    public Example1_CreateNewSpdxDocument()
    {
        _creationInfo = new CreationInfo(_catalog, DateTimeOffset.Now);
    }

    public void CreateNewSpdxDocumentWithSbom()
    {
        var spdxDocument = new SpdxDocument(_catalog, _creationInfo)
        {
            Comment = "This is my new Spdx document.",
            Description = "This is an example of how to create a new SPDX document and put an SBOM in it.",
            Name = "Example1",
            Summary = "This is a sample SPDX document.",
            DataLicense = ListedLicenses.MIT
        };
        var sbom = new Sbom(_catalog, _creationInfo);
        spdxDocument.Element.Add(sbom);
    }
}