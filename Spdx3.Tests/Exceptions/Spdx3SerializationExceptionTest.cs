using Spdx3.Exceptions;

namespace Spdx3.Tests.Exceptions;

public class Spdx3SerializationExceptionTest
{
    [Fact]
    public void Constructor_ShouldSetMessage()
    {
        // Act
        var exception = new Spdx3SerializationException("Some message");

        // Assert
        Assert.IsType<Spdx3Exception>(exception, exactMatch: false);
        Assert.Equal("Some message", exception.Message);
    }

}