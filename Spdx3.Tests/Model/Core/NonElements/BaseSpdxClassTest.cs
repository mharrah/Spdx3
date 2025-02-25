using Spdx3.Utility;

namespace Spdx3.Tests.Model.Core.NonElements;

public class BaseSpdxClassTest : BaseSpdxClassTestClass
{
    [Fact]
    public void BaseSpdxClass_HasReferenceTo_ClassFactory()
    {
        // ARRANGE
        // Get a class using the factory in the base testing class
        var baseClass1 = TestFactory.New<TestBaseSpdxClass>();
        
        // Get another class from a separate factory
        var myOwnFactory = new SpdxClassFactory(PredictableDateTime);
        var baseClass2 = myOwnFactory.New<TestBaseSpdxClass>();

        // ASSERT
        Assert.NotNull(baseClass1.CreatedByFactory);
        Assert.NotNull(baseClass2.CreatedByFactory);
        Assert.NotSame(baseClass1.CreatedByFactory, baseClass2.CreatedByFactory);
        Assert.Same(baseClass1.CreatedByFactory, TestFactory);
        Assert.Same(baseClass2.CreatedByFactory, myOwnFactory);
        
    }
}