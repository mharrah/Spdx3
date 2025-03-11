using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.SimpleLicensing.Classes;

/// <summary>
///     Represents a license combination consisting of one or more licenses
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/SimpleLicensing/Classes/AnyLicenseInfo/
/// </summary>
public abstract class AnyLicenseInfo : Element
{
    // protected internal no-parm constructor required for deserialization
    protected internal AnyLicenseInfo()
    {
    }
    
    // Abstract class, adds no properties or functionality
    [SetsRequiredMembers]
    protected AnyLicenseInfo(SpdxCatalog spdxCatalog, CreationInfo creationInfo) : base(spdxCatalog, creationInfo)
    {
    }
}