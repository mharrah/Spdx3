using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Classes;

/// <summary>
///     A concrete subclass of Element that can be used for testing purposes
/// </summary>
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class TestElement : Element
{
    [SetsRequiredMembers]
    public TestElement(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
    }
}