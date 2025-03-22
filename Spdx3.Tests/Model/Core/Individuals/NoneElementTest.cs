using Spdx3.Model.Core.Individuals;

namespace Spdx3.Tests.Model.Core.Individuals;

public class NoneElementTest : BaseModelTestClass
{
    [Fact]
    public void NoneElement_Spdx_IsConstant()
    {
        // Arrange
        var expected = new Uri("https://spdx.org/rdf/3.0.1/terms/Core/NoneElement");

        // Act
        var noneElement = new NoneElement(TestCatalog, TestCreationInfo);

        // Assert
        Assert.Equal(expected, noneElement.SpdxId);
    }
}