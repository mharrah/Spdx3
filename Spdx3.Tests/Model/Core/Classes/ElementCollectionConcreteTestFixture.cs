using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Classes;

/// <summary>
///     Concrete implementation of ElementCollection (which is abstract) for testing purposes
/// </summary>
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class ElementCollectionConcreteTestFixture : ElementCollection
{
    [SetsRequiredMembers]
    public ElementCollectionConcreteTestFixture(Catalog catalog, CreationInfo creationInfo) : base(catalog,
        creationInfo)
    {
    }
}