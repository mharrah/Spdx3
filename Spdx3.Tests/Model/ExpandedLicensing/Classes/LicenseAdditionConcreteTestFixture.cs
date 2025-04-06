using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

public class LicenseAdditionConcreteTestFixture : LicenseAddition
{
    internal LicenseAdditionConcreteTestFixture()
    {
    }

    [SetsRequiredMembers]
    public LicenseAdditionConcreteTestFixture(Catalog catalog, CreationInfo creationInfo, string additionText) : base(catalog, creationInfo, additionText)
    {
    }
}