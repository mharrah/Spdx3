using System.Diagnostics.CodeAnalysis;
using Spdx3.Model;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Classes;

/// <summary>
///     Concrete implementation of the abstract BaseSpdxClass class, so it can be tested
/// </summary>
public class TestBaseSpdxClassBadValidator : BaseSpdxClass
{
    [SetsRequiredMembers]
    public TestBaseSpdxClassBadValidator(SpdxCatalog spdxCatalog) : base(spdxCatalog)
    {
    }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty("This property doesn't exist on the class");
    }
}