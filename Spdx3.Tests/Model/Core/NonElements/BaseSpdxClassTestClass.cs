using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

/// <summary>
///     Base class for all tests of SpdxClass (and its subclasses). Has convenience methods to keep things predictable and
///     less repetitive.
/// </summary>
public class BaseSpdxClassTestClass
{
    protected static readonly DateTimeOffset PredictableDateTime = new(2025, 02, 22, 1, 23, 45, TimeSpan.Zero);

    protected BaseSpdxClassTestClass()
    {
        TestFactory.CreationDate = PredictableDateTime;
    }

    protected SpdxClassFactory TestFactory { get; } = new();
    
}