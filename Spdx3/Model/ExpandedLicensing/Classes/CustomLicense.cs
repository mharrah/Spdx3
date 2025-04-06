using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.ExpandedLicensing.Classes;

/// <summary>
/// A license that is not listed on the SPDX License List.
/// https://spdx.github.io/spdx-spec/v3.0.1/model/ExpandedLicensing/Classes/CustomLicense/
/// </summary>
public class CustomLicense : License
{
    /// <summary>
    /// No-arg constructor required for serialization/deserialization
    /// </summary>
    protected internal CustomLicense()
    {
    }

    [SetsRequiredMembers]
    public CustomLicense(Catalog catalog, CreationInfo creationInfo, string licenseText) : base(catalog, creationInfo, licenseText)
    {
    }
}