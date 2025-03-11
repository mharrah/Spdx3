using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     An element of hardware and/or software utilized to carry out a particular function.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Tool/
/// </summary>
public class Tool : Element
{
    // protected internal no-parm constructor required for deserialization
    protected internal Tool()
    {
    }
    
    [SetsRequiredMembers]
    public Tool(SpdxCatalog spdxCatalog, CreationInfo creationInfo) : base(spdxCatalog, creationInfo)
    {
    }
}