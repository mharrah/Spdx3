using Microsoft.VisualBasic;
using Spdx3.Model;
using Spdx3.Model.Core.NonElements;
using Spdx3.Tests.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Elements;

/// <summary>
/// Base class for all tests of Element (and its subclasses). Has convenience methods to keep things predictable and
/// less repetitive.
/// </summary>
public class BaseElementTestClass : BaseSpdxClassTestClass
{
    protected CreationInfo TestCreationInfo { get; }   

    protected BaseElementTestClass()
    {
        this.TestCreationInfo = TestFactory.New<CreationInfo>();
    }
}