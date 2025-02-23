using Spdx3.Model;

namespace Spdx3.Tests.Model.Core.Elements;


public class ElementTest : BaseElementTest
{
    [Fact]
    public void Requires_CreationInfo_Parameter()
    {
        // Act - note, no parameter
        var exception = Record.Exception(() => TestFactory.New<TestElement>());
        Assert.NotNull(exception);
    }
    
    [Fact]
    public void BrandNew_Element_HasRequiredFields()
    {
        // Arrange
        TestElement element = TestFactory.New<TestElement>(this.TestCreationInfo);
        
        // Assert
        element.Validate();
        Assert.Null(Record.Exception(() => element.Validate()));
        Assert.Equal("TestElement", element.Type);

    }
}