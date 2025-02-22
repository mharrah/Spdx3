using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

/// <summary>
/// A group of people who work together in an organized way for a shared purpose.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Organization/
/// </summary>
public class Organization : Agent
{
    [SetsRequiredMembers]
    public Organization(ISpdxIdFactory idFactory, CreationInfo creationInfo) : base(idFactory, creationInfo)
    {
        // Need to override the values created in the Agent class
        Type = "Organization";
        SpdxId = idFactory.New(Type);
    }
}