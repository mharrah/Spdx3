using Spdx3.Model.Core.Individuals;

namespace Spdx3.Tests.Model.SimpleLicensing.Individuals;

public class NoneElementTest : BaseModelTestClass
{
    [Fact]
    public void NoneElement_Spdx_IsConstant()
    {
        // Arrange
        const string expected = "https://spdx.org/rdf/3.0.1/terms/Core/NoneElement";
            
        // Act
        var noneElement = new NoneElement(TestSpdxIdFactory, TestCreationInfo);
        
        // Assert
        Assert.Equal(expected, noneElement.SpdxId);
    }
}