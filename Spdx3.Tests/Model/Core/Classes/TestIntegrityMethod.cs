using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Classes;

/// <summary>
///     A concrete implementation of the abstract IntegrityMethod class to be used for testing
/// </summary>
public class TestIntegrityMethod : IntegrityMethod
{
    [SetsRequiredMembers]
    public TestIntegrityMethod(SpdxIdFactory spdxIdFactory) : base(spdxIdFactory)
    {
    }
}