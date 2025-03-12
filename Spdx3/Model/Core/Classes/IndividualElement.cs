using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A concrete subclass of Element used by Individuals in the Core profile (whatever *that* means)
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/IndividualElement/
/// </summary>
public class IndividualElement : Element
{
    // protected internal no-parm constructor required for deserialization
    protected internal IndividualElement()
    {
    }

    [SetsRequiredMembers]
    public IndividualElement(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}