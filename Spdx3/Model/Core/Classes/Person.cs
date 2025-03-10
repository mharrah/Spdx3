﻿using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     An individual human being.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Person/
/// </summary>
public class Person : Agent
{
    [SetsRequiredMembers]
    public Person(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
    }
}