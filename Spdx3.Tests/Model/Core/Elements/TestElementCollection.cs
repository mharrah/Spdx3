using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Elements;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Elements;

/// <summary>
///     Concrete implementation of ElementCollection (which is abstract) for testing purposes
/// </summary>
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class TestElementCollection : ElementCollection
{
    [SetsRequiredMembers]
    public TestElementCollection(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory,
        creationInfo)
    {
    }
}