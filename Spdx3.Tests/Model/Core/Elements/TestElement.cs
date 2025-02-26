using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.Elements;

/// <summary>
///     A concrete subclass of Element that can be used for testing purposes
/// </summary>
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class TestElement : Element
{
    internal TestElement()
    {
        
    }
}