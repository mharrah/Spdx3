using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     An element of hardware and/or software utilized to carry out a particular function.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Tool/
/// </summary>
public class Tool : Element
{
    [SetsRequiredMembers]
    public Tool(ISpdxIdFactory idFactory, CreationInfo creationInfo) : base(idFactory, "Tool", creationInfo)
    {
    }
}