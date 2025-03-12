using Spdx3.Exceptions;
using Spdx3.Tests.Model.Core.Classes;
using Spdx3.Utility;

namespace Spdx3.Tests.Exceptions;

public class Spdx3ValidationExceptionTest
{
    [Fact]
    public void Constructor_ShouldSetMessage()
    {
        // Arrange
        var cut = new TestBaseModelClass(new Catalog());

        // Act
        var exception = new Spdx3ValidationException(cut, nameof(cut.SpdxId), "Some message");

        // Assert
        Assert.Equal("Object TestBaseModelClass, property SpdxId: Some message", exception.Message);
    }
}