namespace Spdx3.Tests.Model.Core.Classes;

public class BaseSpdxClassTest : BaseModelTestClass
{
    [Fact]
    public void BaseSpdxClass_NewElements_AreDifferent()
    {
        // ARRANGE
        // Get a class using the factory in the base testing class
        var baseClass1 = new TestBaseSpdxClass(TestSpdxIdFactory);

        // Get another class from a separate factory
        var baseClass2 = new TestBaseSpdxClass(TestSpdxIdFactory);

        // ASSERT
        Assert.NotNull(baseClass1);
        Assert.NotNull(baseClass2);
        Assert.NotEqual(baseClass1, baseClass2);
    }
}