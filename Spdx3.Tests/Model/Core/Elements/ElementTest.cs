using Spdx3.Model;

namespace Spdx3.Tests.Model.Core.Elements;


public class ElementTest : BaseElementTest
{
    [Fact]
    public void BrandNew_Element_HasRequiredFields()
    {
        // Arrange
        var element = TestFactory.New<TestElement>();
        
        // Assert
        Assert.Equal("TestElement", element.Type);

    }
}