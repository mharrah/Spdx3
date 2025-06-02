using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

/// <summary>
/// A license addition that is not listed on the SPDX Exceptions List.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/ExpandedLicensing/Classes/CustomLicenseAddition/
/// </summary>
public class CustomLicenseAddition : LicenseAddition
{
    /// <summary>
    /// No-arg constructor required for serialization/deserialization
    /// </summary>
    internal CustomLicenseAddition()
    {
    }

    [SetsRequiredMembers]
    public CustomLicenseAddition(Catalog catalog, CreationInfo creationInfo, string additionText) : base(catalog,
        creationInfo, additionText)
    {
    }
}