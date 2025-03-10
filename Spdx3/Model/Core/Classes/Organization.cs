﻿using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A group of people who work together in an organized way for a shared purpose.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Organization/
/// </summary>
public class Organization : Agent
{
    [SetsRequiredMembers]
    public Organization(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
    }
}