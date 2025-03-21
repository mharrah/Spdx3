using System.Diagnostics.CodeAnalysis;
using Spdx3.Model;
using Spdx3.Utility;

namespace Spdx3.Tests.Model;

/// <summary>
/// A concrete implementation of the abstract BaseModelClass class, for testing
/// </summary>
public class TestBaseModelClass : BaseModelClass
{
    public string? StringProperty { get; set; }
    public IList<string>? StringListProperty { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(StringProperty));
        ValidateRequiredProperty(nameof(StringListProperty));
    }
}