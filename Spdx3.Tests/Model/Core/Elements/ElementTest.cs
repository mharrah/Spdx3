using Spdx3.Model;

namespace Spdx3.Tests.Model.Core.Elements;


public class ElementTest : BaseElementTestClass
{
    [Fact]
    public void Requires_CreationInfo_Parameter()
    {
        // Act - note, no parameter
        var exception = Record.Exception(() => TestFactory.New<TestElement>());
        Assert.NotNull(exception);
        Assert.Equal("Parameter of type CreationInfo required when creating subclasses of Element", exception.Message);
    }
    
    [Fact]
    public void BrandNew_Element_HasRequiredFields()
    {
        // Arrange
        var element = TestFactory.New<TestElement>(this.TestCreationInfo);
        
        // Assert
        Assert.Null(Record.Exception(() => element.Validate()));
        Assert.Equal("TestElement", element.Type);
    }

    [Fact]
    public void BrandNew_Element_SerializesProperly()
    {
        // Arrange
        var element = TestFactory.New<TestElement>(this.TestCreationInfo);
        const string expected = """
                                {
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "type": "TestElement",
                                  "spdxId": "urn:TestElement:402"
                                }
                                """;
        
        // Act
        var json = element.ToJson();
        
        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void FullyPopulated_Element_SerializesProperly()
    {
        // Arrange
        var element = TestFactory.New<TestElement>(this.TestCreationInfo);
        element.Comment = "TestComment";
        element.Description = "TestDescription";
        element.Name = "TestName";
        
        const string expected = """
                                {
                                  "comment": "TestComment",
                                  "creationInfo": "urn:CreationInfo:3f5",
                                  "description": "TestDescription",
                                  "name": "TestName",
                                  "type": "TestElement",
                                  "spdxId": "urn:TestElement:402"
                                }
                                """;
        
        // Act
        var json = element.ToJson();
        
        // Assert
        Assert.Equal(expected, json);
    }

    [Fact]
    public void TypeNew_Element_FailsValidation_Empty_SpdxId()
    {
        // Arrange
        var element = TestFactory.New<TestElement>(this.TestCreationInfo);
        element.SpdxId = string.Empty;
        
        // Act
        var exception = Record.Exception(() => element.Validate());
        
        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object TestElement, property SpdxId: Field is empty", exception.Message);
    }
    
    
    [Fact]
    public void TypeNew_Element_FailsValidation_Empty_Type()
    {
        // Arrange
        var element = TestFactory.New<TestElement>(this.TestCreationInfo);
        element.Type = string.Empty;
        
        // Act
        var exception = Record.Exception(() => element.Validate());
        
        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Object TestElement, property Type: Field is empty", exception.Message);
    }
}