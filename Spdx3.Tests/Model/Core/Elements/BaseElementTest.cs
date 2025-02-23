using Microsoft.VisualBasic;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Elements;

/// <summary>
/// Base class for all tests of Element (and its subclasses). Has convenience methods to keep things predictable and
/// less repetitive.
/// </summary>
public class BaseElementTest
{
    private static readonly DateTimeOffset PredictableDateTime = new DateTimeOffset(2025, 02, 22, 1, 23, 45, TimeSpan.Zero);
    protected SpdxClassFactory Factory { get; } = new SpdxClassFactory();

    protected CreationInfo CreationInfo { get; }   

    protected BaseElementTest()
    {
        Factory.CreationDate = PredictableDateTime;
        this.CreationInfo = (CreationInfo)Factory.NewClass(typeof(CreationInfo));
    }
    
    
}