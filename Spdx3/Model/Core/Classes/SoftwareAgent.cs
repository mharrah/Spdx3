using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A software agent.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/SoftwareAgent/
/// </summary>
public class SoftwareAgent : Agent
{
    // protected internal no-parm constructor required for deserialization
    protected internal SoftwareAgent()
    {
    }

    [SetsRequiredMembers]
    public SoftwareAgent(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}