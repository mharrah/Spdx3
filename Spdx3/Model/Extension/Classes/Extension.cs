using System.Diagnostics.CodeAnalysis;
using Spdx3.Utility;

namespace Spdx3.Model.Extension.Classes;

/// <summary>
///     A characterization of some aspect of an Element that is associated with the Element in a generalized fashion.
///     See https://spdx.github.io/spdx-spec/v3.0.1/model/Extension/Classes/Extension/
/// </summary>
public abstract class Extension : BaseSpdxClass
{
    [SetsRequiredMembers]
    protected Extension(SpdxIdFactory spdxIdFactory) : base(spdxIdFactory)
    {
    }
}