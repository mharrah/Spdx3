using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Extension;

/// <summary>
///     Concrete implementation of the abstract Extension class, for testing purposes
/// </summary>
public class TestExtension : Spdx3.Model.Extension.Extension
{
    [SetsRequiredMembers]
    public TestExtension(SpdxIdFactory spdxIdFactory) : base(spdxIdFactory)
    {
    }
}