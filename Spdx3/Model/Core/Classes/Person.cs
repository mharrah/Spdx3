using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     An individual human being.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Person/
/// </summary>
public class Person : Agent
{
    // protected internal no-parm constructor required for deserialization
    protected internal Person()
    {
    }

    [SetsRequiredMembers]
    public Person(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}