using Spdx3.Exceptions;

namespace Spdx3.Tests.Model.Core.Classes;

public class BaseSpdxClassTest : BaseModelTestClass
{
    [Fact]
    public void BaseSpdxClass_NewElements_AreDifferent()
    {
        // ARRANGE
        // Get a class using the id factory method in the catalog in the base testing class
        var baseClass1 = new TestBaseSpdxClass(TestSpdxCatalog);

        // Get another class the same catalog
        var baseClass2 = new TestBaseSpdxClass(TestSpdxCatalog);

        // ASSERT
        Assert.NotNull(baseClass1);
        Assert.NotNull(baseClass2);
        Assert.NotEqual(baseClass1, baseClass2);
    }

    [Fact]
    public void Validate_Throws_If_PropertyName_Is_Wrong()
    {
        // Arrange
        var baseClass1 = new TestBaseSpdxClassBadValidator(TestSpdxCatalog);
        
        // Act
        var exception = Record.Exception(() => baseClass1.Validate());
        
        // Assert
        Assert.NotNull(exception);
        Assert.IsType<Spdx3ValidationException>(exception);
        Assert.Equal("Object TestBaseSpdxClassBadValidator, property 'This property doesn't exist on the class': " +
                     "No such property exists", exception.Message);

    }
}