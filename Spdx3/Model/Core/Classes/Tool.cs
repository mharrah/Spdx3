﻿using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     An element of hardware and/or software utilized to carry out a particular function.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Tool/
/// </summary>
public class Tool : Element
{
    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once UnusedMember.Global
    protected internal Tool()
    {
    }

    [SetsRequiredMembers]
    public Tool(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}