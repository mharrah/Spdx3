using Spdx3.Model;

namespace Spdx3.Tests.Model;

/// <summary>
/// A concrete implementation of the abstract BaseModelClass class, for testing
/// </summary>
public class BaseModelClassConcreteTestFixture : BaseModelClass
{
    public IList<string>? StringListProperty { get; set; }
    public string? StringProperty { get; set; }

    public override void Validate()
    {
        base.Validate();
        ValidateRequiredProperty(nameof(StringProperty));
        ValidateRequiredProperty(nameof(StringListProperty));
    }
}