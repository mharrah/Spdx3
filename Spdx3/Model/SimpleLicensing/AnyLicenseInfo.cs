using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.SimpleLicensing;

/// <summary>
///     Represents a license combination consisting of one or more licenses
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/SimpleLicensing/Classes/AnyLicenseInfo/
/// </summary>
public abstract class AnyLicenseInfo : Element
{
    // Abstract class, adds no properties or functionality

    [SetsRequiredMembers]
    protected AnyLicenseInfo(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
    }
}