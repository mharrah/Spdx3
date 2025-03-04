using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Individuals;

/// <summary>
/// An Organization representing the SPDX Project.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Individuals/SpdxOrganization/
/// </summary>
public class SpdxOrganization : Organization
{
    [SetsRequiredMembers]
    public SpdxOrganization(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
        SpdxId = "https://spdx.org/";
    }
}