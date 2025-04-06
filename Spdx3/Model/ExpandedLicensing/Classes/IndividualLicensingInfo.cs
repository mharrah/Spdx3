using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

/// <summary>
/// A concrete subclass of AnyLicenseInfo used by Individuals in the ExpandedLicensing profile.
/// https://spdx.github.io/spdx-spec/v3.0.1/model/ExpandedLicensing/Classes/IndividualLicensingInfo/
/// </summary>
public class IndividualLicensingInfo : AnyLicenseInfo
{
    /// <summary>
    /// No-arg constructor required for serialization/deserialization
    /// </summary>
    protected internal IndividualLicensingInfo()
    {
    }

    [SetsRequiredMembers]
    public IndividualLicensingInfo(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}