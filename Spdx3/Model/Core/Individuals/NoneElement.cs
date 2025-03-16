using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Individuals;

/// <summary>
///     An Individual Value for Element representing a set of Elements with cardinality (number/count) of zero.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Individuals/NoAssertionElement/
/// </summary>
public class NoneElement : Element
{
    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal NoneElement()
    {
    }

    [SetsRequiredMembers]
    public NoneElement(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
        SpdxId = "https://spdx.org/rdf/3.0.1/terms/Core/NoneElement";
    }
}