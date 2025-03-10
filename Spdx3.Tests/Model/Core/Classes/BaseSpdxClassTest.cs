using Spdx3.Exceptions;

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

    [Fact]
    public void Validate_Throws_If_PropertyName_Is_Wrong()
    {
        // Arrange
        var baseClass1 = new TestBaseSpdxClassBadValidator(TestSpdxIdFactory);
        
        // Act
        var exception = Record.Exception(() => baseClass1.Validate());
        
        // Assert
        Assert.NotNull(exception);
        Assert.IsType<Spdx3ValidationException>(exception);
        Assert.Equal("Object TestBaseSpdxClassBadValidator, property 'This property doesn't exist on the class': " +
                     "No such property exists", exception.Message);

    }
}