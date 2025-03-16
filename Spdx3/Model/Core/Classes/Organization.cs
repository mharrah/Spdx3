using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A group of people who work together in an organized way for a shared purpose.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Organization/
/// </summary>
public class Organization : Agent
{
    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once MemberCanBeProtected.Global
    protected internal Organization()
    {
    }

    [SetsRequiredMembers]
    public Organization(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}