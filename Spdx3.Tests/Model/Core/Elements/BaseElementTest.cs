using Microsoft.VisualBasic;
using Spdx3.Model;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.Elements;

/// <summary>
/// Base class for all tests of Element (and its subclasses). Has convenience methods to keep things predictable and
/// less repetitive.
/// </summary>
public class BaseElementTest : BaseSpdxClassTest
{
    protected CreationInfo TestCreationInfo { get; }   

    protected BaseElementTest()
    {
        this.TestCreationInfo = TestFactory.New<CreationInfo>();
    }
}