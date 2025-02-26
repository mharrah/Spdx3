using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.Elements;

namespace Spdx3.Tests.Model.Core.Elements;

/// <summary>
///     Concrete implementation of the abstract Artifact class for use in testing
/// </summary>
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class TestArtifact : Artifact
{
    internal TestArtifact()
    {
        
    }
}