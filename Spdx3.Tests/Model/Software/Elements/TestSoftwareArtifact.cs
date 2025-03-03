using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.NonElements;
using Spdx3.Model.Software.Elements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Software.Elements;

/// <summary>
/// Concrete implementation of the abstrace SoftwareArtifact class, for testing
/// </summary>
public class TestSoftwareArtifact : SoftwareArtifact
{
    [SetsRequiredMembers]
    public TestSoftwareArtifact(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory,
        creationInfo)
    {
    }
}