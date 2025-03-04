using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Individuals;

/// <summary>
/// An Individual Value for Element representing a set of Elements of unknown identity or cardinality (number).
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Individuals/NoAssertionElement/
/// </summary>
public class NoAssertionElement : Element
{
    [SetsRequiredMembers]
    public NoAssertionElement(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
        SpdxId = "https://spdx.org/rdf/3.0.1/terms/Core/NoAssertionElement";
    }
}