using System.Diagnostics.CodeAnalysis;
using Spdx3.Model;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Classes;

/// <summary>
///     Concrete implementation of the abstract BaseModelClass class, so it can be tested
/// </summary>
public class TestBaseModelClass : BaseModelClass
{
    [SetsRequiredMembers]
    public TestBaseModelClass(Catalog catalog) : base(catalog)
    {
    }
}