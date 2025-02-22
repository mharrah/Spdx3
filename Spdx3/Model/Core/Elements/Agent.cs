﻿using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     The Agent class represents anything that has the potential to act on a system.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Agent/
/// </summary>
public class Agent : Element
{
    [SetsRequiredMembers]
    public Agent(ISpdxIdFactory idFactory, CreationInfo creationInfo) : base(idFactory, "Agent", creationInfo)
    {
    }
}