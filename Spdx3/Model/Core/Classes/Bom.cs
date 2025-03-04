using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A Bill of Materials (BOM) is a container for a grouping of SPDX-3.0 content characterizing details about a product.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Bom/
/// </summary>
public class Bom : Bundle
{
    [SetsRequiredMembers]
    public Bom(SpdxIdFactory spdxIdFactory, CreationInfo creationInfo) : base(spdxIdFactory, creationInfo)
    {
    }
}