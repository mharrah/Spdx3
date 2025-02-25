using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.NonElements;

namespace Spdx3.Tests.Model.Core.Elements;

/// <summary>
///     Base class for all tests of Element (and its subclasses). Has convenience methods to keep things predictable and
///     less repetitive.
/// </summary>
public class BaseElementTestClass : BaseSpdxClassTestClass
{
    protected BaseElementTestClass()
    {
        TestCreationInfo = TestFactory.New<CreationInfo>();
    }

    protected CreationInfo TestCreationInfo { get; }
}