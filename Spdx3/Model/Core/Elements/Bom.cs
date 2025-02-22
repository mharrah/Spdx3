using System.Diagnostics.CodeAnalysis;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Model.Core.Elements;

/// <summary>
/// A Bill of Materials (BOM) is a container for a grouping of SPDX-3.0 content characterizing details about a product.
/// See https://spdx.github.io/spdx-spec/v3.0.1/model/Core/Classes/Bom/
/// </summary>
public class Bom : Bundle
{
    [SetsRequiredMembers]
    protected Bom(ISpdxIdFactory idFactory, CreationInfo creationInfo) : base(idFactory, creationInfo)
    {
        // Need to override the values created in the Bundle class
        Type = "Bom";
        SpdxId = idFactory.New(Type);
    }
}