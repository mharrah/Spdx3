using Spdx3.Exceptions;

namespace Spdx3.Tests.Model;

/// <summary>
/// Test for the abstract BaseModelClass type, using the TestBaseModelClass as the concrete implementation.
/// </summary>
public class BaseModelClassTest : BaseModelTestClass
{
    [Fact]
    public void Validate_WorksWhen_PropertiesAreSet()
    {
        // Arrange
        var testBaseModelClass = new TestBaseModelClass()
        {
            Type = "Test",
            SpdxId = "TestSpdxId",
            StringProperty = "TestStringProperty",
            StringListProperty = ["TestStringListProperty", "TestStringListProperty2"],
        };
        
        // Act
        var exception = Record.Exception(() => testBaseModelClass.Validate());
        
        // Assert
        Assert.Null(exception);
    }
    
    [Fact]
    public void Validate_ThrowsWhen_StringProperty_NullValue()
    {
        // Arrange
        var testBaseModelClass = new TestBaseModelClass()
        {
            Type = "Test",
            SpdxId = "TestSpdxId",
            StringProperty = "TestStringProperty",
            StringListProperty = ["TestStringListProperty", "TestStringListProperty2"],
        };
        
        testBaseModelClass.StringProperty = null;  // Set the bad value
        
        // Act and Assert
        Assert.Throws<Spdx3ValidationException>(() => testBaseModelClass.Validate());
    }
    
    
    [Fact]
    public void Validate_ThrowsWhen_ListProperty_NullValue()
    {
        // Arrange
        var testBaseModelClass = new TestBaseModelClass()
        {
            Type = "Test",
            SpdxId = "TestSpdxId",
            StringProperty = "TestStringProperty",
            StringListProperty = ["TestStringListProperty", "TestStringListProperty2"],
        };
        
        testBaseModelClass.StringListProperty = null;  // Set the bad value
        
        // Act and Assert
        Assert.Throws<Spdx3ValidationException>(() => testBaseModelClass.Validate());
    }
    
    [Fact]
    public void Validate_ThrowsWhen_StringProperty_Empty()
    {
        // Arrange
        var testBaseModelClass = new TestBaseModelClass()
        {
            Type = "Test",
            SpdxId = "TestSpdxId",
            StringProperty = "TestStringProperty",
            StringListProperty = ["TestStringListProperty", "TestStringListProperty2"],
        };
        
        testBaseModelClass.StringProperty = "";  // Set the bad value
        
        // Act and Assert
        Assert.Throws<Spdx3ValidationException>(() => testBaseModelClass.Validate());
    }

    [Fact]
    public void Validate_ThrowsWhen_StringListProperty_Empty()
    {
        // Arrange
        var testBaseModelClass = new TestBaseModelClass()
        {
            Type = "Test",
            SpdxId = "TestSpdxId",
            StringProperty = "TestStringProperty",
            StringListProperty = ["TestStringListProperty", "TestStringListProperty2"],
        };
        
        testBaseModelClass.StringListProperty.Clear();  // Set the bad value
        
        // Act and Assert
        Assert.Throws<Spdx3ValidationException>(() => testBaseModelClass.Validate());
    }

    
}