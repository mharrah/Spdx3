using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.SimpleLicensing.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

/// <summary>
/// Abstract class representing a License or an OrLaterOperator.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/ExpandedLicensing/Classes/ExtendableLicense/
/// </summary>
public abstract class ExtendableLicense : AnyLicenseInfo
{
    /// <summary>
    /// No-arg constructor required for serialization/deserialization
    /// </summary>
    protected ExtendableLicense() : base()
    {
    }

    [SetsRequiredMembers]
    protected ExtendableLicense(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}