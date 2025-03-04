using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Classes;

/// <summary>
///     Concrete implementation of the abstract Artifact class for use in testing
/// </summary>
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class TestArtifact : Artifact
{
    [SetsRequiredMembers]
    public TestArtifact(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
    }
}