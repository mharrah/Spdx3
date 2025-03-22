using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.SimpleLicensing.Classes;

/// <summary>
///     Concrete implementation of the abstract class AnyClassInfo, so it can be tested
/// </summary>
public class AnyLicenseInfoConcreteTestFixture : AnyLicenseInfo
{
    [SetsRequiredMembers]
    public AnyLicenseInfoConcreteTestFixture(Catalog catalog, CreationInfo creationInfo) : base(catalog,
        creationInfo)
    {
    }
}