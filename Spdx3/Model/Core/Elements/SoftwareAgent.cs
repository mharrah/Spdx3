using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     A software agent.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/SoftwareAgent/
/// </summary>
public class SoftwareAgent : Agent
{
    [SetsRequiredMembers]
    public SoftwareAgent(ISpdxIdFactory idFactory, CreationInfo creationInfo) : base(idFactory, creationInfo)
    {
        // Need to override the values created in the Agent class
        Type = "SoftwareAgent";
        SpdxId = idFactory.New(Type);
    }
}