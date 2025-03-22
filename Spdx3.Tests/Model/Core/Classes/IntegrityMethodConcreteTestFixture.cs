using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Classes;

/// <summary>
///     A concrete implementation of the abstract IntegrityMethod class to be used for testing
/// </summary>
public class IntegrityMethodConcreteTestFixture : IntegrityMethod
{
    [SetsRequiredMembers]
    public IntegrityMethodConcreteTestFixture(Catalog catalog) : base(catalog)
    {
    }
}