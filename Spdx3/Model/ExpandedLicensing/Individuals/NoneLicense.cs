using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Individuals;

public class NoneLicense : IndividualLicensingInfo
{
    protected internal NoneLicense()
    {
    }

    [SetsRequiredMembers]
    public NoneLicense(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
        SpdxId = new Uri("https://spdx.org/rdf/3.0.1/terms/Licensing/None");
    }
}