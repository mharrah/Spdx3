using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model;

/// <summary>
///     Base class for all tests of SpdxClass (and its subclasses). Has convenience methods to keep things predictable and
///     less repetitive.
/// </summary>
public class BaseModelTestClass
{
    protected static readonly DateTimeOffset PredictableDateTime = new(2025, 02, 22, 1, 23, 45, TimeSpan.Zero);

    protected BaseModelTestClass()
    {
        TestCreationInfo = new CreationInfo(TestSpdxIdFactory, PredictableDateTime);
    }

    protected CreationInfo TestCreationInfo { get; set; }

    protected SpdxIdFactory TestSpdxIdFactory { get; set; } = new();
}