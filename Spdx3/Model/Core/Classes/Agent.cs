using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Lite;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     The Agent class represents anything that has the potential to act on a system.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Agent/
/// </summary>
public class Agent : Element, ILiteDomainCompliantElement
{
    // protected internal no-parm constructor required for deserialization
    // ReSharper disable once MemberCanBeProtected.Global
    protected internal Agent()
    {
    }

    [SetsRequiredMembers]
    public Agent(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }

    public void Accept(ILiteDomainComplianceVisitor visitor)
    {
        visitor.Visit(this);
    }
}