using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.Elements;

/// <summary>
///     Concrete implementation of ElementCollection (which is abstract) for testing purposes
/// </summary>
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class TestElementCollection : ElementCollection
{
    internal TestElementCollection()
    {
        
    }
}