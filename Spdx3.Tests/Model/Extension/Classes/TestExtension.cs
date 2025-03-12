using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Extension.Classes;

/// <summary>
///     Concrete implementation of the abstract Extension class, for testing purposes
/// </summary>
public class TestExtension : Spdx3.Model.Extension.Classes.Extension
{
    [SetsRequiredMembers]
    public TestExtension(Catalog catalog) : base(catalog)
    {
    }
}