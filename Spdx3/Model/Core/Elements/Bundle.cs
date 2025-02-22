using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     A collection of Elements that have a shared context.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Bundle/
/// </summary>
public class Bundle : ElementCollection
{
    [SetsRequiredMembers]
    protected Bundle(ISpdxIdFactory idFactory, CreationInfo creationInfo) : base(idFactory, "Bundle", creationInfo)
    {
    }
}