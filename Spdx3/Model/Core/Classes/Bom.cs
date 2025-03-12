using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Classes;

/// <summary>
///     A Bill of Materials (BOM) is a container for a grouping of SPDX-3.0 content characterizing details about a product.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Bom/
/// </summary>
public class Bom : Bundle
{
    // protected internal no-parm constructor required for deserialization
    protected internal Bom()
    {
    }

    [SetsRequiredMembers]
    public Bom(Catalog catalog, CreationInfo creationInfo) : base(catalog, creationInfo)
    {
    }
}