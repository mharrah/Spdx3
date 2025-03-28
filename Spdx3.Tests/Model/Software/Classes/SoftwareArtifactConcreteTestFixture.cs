using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Model.Software.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Software.Classes;

/// <summary>
///     Concrete implementation of the abstract SoftwareArtifact class, for testing
/// </summary>
public class SoftwareArtifactConcreteTestFixture : SoftwareArtifact
{
    [SetsRequiredMembers]
    public SoftwareArtifactConcreteTestFixture(Catalog catalog, CreationInfo creationInfo) : base(catalog,
        creationInfo)
    {
    }
}