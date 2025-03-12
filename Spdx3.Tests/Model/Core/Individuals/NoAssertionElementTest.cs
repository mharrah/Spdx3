using Spdx3.Model.Core.Individuals;

namespace Spdx3.Tests.Model.Core.Individuals;

public class NoAssertionElementTest : BaseModelTestClass
{
    [Fact]
    public void NoAssertionElement_Spdx_IsConstant()
    {
        // Arrange
        const string expected = "https://spdx.org/rdf/3.0.1/terms/Core/NoAssertionElement";
            
        // Act
        var noAssertion = new NoAssertionElement(TestCatalog, TestCreationInfo);
        
        // Assert
        Assert.Equal(expected, noAssertion.SpdxId);
    }
}