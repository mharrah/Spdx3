using System.Diagnostics.CodeAnalysis;
using Spdx3.Model;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Classes;

/// <summary>
///     Concrete implementation of the abstract BaseSpdxClass class, so it can be tested
/// </summary>
public class TestBaseSpdxClass : BaseSpdxClass
{
    [SetsRequiredMembers]
    public TestBaseSpdxClass(SpdxIdFactory spdxIdFactory) : base(spdxIdFactory)
    {
    }
}