using Spdx3.Exceptions;
using Spdx3.Model.Core.NonElements;
using Spdx3.Utility;

namespace Spdx3.Tests.Exceptions;

public class Spdx3ValidationExceptionTest
{
    [Fact]
    public void Constructor_ShouldSetMessage()
    {
        // Arrange
        var factory = new SpdxClassFactory();
        var hash = factory.New<Hash>();

        // Act
        var exception = new Spdx3ValidationException(hash, nameof(hash.Algorithm), "Some message");

        // Assert
        Assert.Equal("Object Hash, property Algorithm: Some message", exception.Message);
    }
}