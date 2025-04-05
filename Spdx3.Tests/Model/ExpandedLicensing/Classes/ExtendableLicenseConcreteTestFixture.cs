using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.ExpandedLicensing.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.ExpandedLicensing.Classes;

/// <summary>
/// Concrete implementation of the abstract ExtendableLicense class for testing purposes
/// </summary>
public class ExtendableLicenseConcreteTestFixture : ExtendableLicense
{
    public ExtendableLicenseConcreteTestFixture()
    {
    }

    [SetsRequiredMembers]
    public ExtendableLicenseConcreteTestFixture(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}