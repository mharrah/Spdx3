using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Individuals;

/// <summary>
///     An Organization representing the SPDX Project.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Individuals/SpdxOrganization/
/// </summary>
public class SpdxOrganization : IndividualElement
{
    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal SpdxOrganization()
    {
    }

    [SetsRequiredMembers]
    public SpdxOrganization(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
        SpdxId = new Uri("https://spdx.org/");
    }
}