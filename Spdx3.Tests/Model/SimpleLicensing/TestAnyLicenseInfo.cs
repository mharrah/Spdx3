using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.SimpleLicensing;

/// <summary>
///     Concrete implementation of the abstract class AnyClassInfo, so it can be tested
/// </summary>
public class TestAnyLicenseInfo : Element
{
    [SetsRequiredMembers]
    public TestAnyLicenseInfo(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory,
        creationInfo)
    {
    }
}