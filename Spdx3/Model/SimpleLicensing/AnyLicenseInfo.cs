using Spdx3.Model.Core.Elements;

namespace Spdx3.Model.SimpleLicensing;

/// <summary>
///     Represents a license combination consisting of one or more licenses
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/SimpleLicensing/Classes/AnyLicenseInfo/
/// </summary>
public abstract class AnyLicenseInfo : Element
{
    // Abstract class, adds no properties or functionality

    protected internal AnyLicenseInfo()
    {
    }
}