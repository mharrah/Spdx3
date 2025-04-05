using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

/// <summary>
/// Concrete implementation of the abstract License class for testing purposes
/// </summary>
public class LicenseConcreteTestFixture : License
{
    public LicenseConcreteTestFixture()
    {
    }

    [SetsRequiredMembers]
    public LicenseConcreteTestFixture(Catalog catalog, CreationInfo creationInfo, string licenseText) 
        : base(catalog, creationInfo, licenseText)
    {
    }
}