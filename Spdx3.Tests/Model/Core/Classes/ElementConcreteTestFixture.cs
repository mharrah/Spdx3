using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Classes;

/// <summary>
///     A concrete subclass of Element that can be used for testing purposes
/// </summary>
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class ElementConcreteTestFixture : Element
{
    // protected internal no-parm constructor required for deserialization
    protected internal ElementConcreteTestFixture()
    {
    }

    [SetsRequiredMembers]
    public ElementConcreteTestFixture(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}