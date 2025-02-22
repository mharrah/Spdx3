using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

/// <summary>
///     An individual human being.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Person/
/// </summary>
public class Person : Agent
{
    [SetsRequiredMembers]
    public Person(ISpdxIdFactory idFactory, CreationInfo creationInfo) : base(idFactory, creationInfo)
    {
        // Need to override the values created in the Agent class
        Type = "Person";
        SpdxId = idFactory.New(Type);
    }
}