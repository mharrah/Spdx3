using Spdx3.Exceptions;

namespace Spdx3.Tests.Exceptions;

public class Spdx3ExceptionTest
{
    [Fact]
    public void Spdx3Exception_Message_ShouldNotBeNullOrEmpty()
    {
        var message = string.Empty;
        var expected = Record.Exception(() => new Spdx3Exception(message));
        Assert.NotNull(expected);
        Assert.IsType<ArgumentNullException>(expected);
    }

    [Fact]
    public void Spdx3Exception_InnerException_ShouldNotBeNull()
    {
        Exception? innerException = null;
#pragma warning disable CS8604 // Possible null reference argument.
        var expected = Record.Exception(() => new Spdx3Exception("Something bad happened", innerException));
#pragma warning restore CS8604 // Possible null reference argument.
        Assert.NotNull(expected);
        Assert.IsType<ArgumentNullException>(expected);
    }
    
    
    [Fact]
    public void Spdx3Exception_InnerException_Can_Be_Supplied()
    {
        Exception innerException = new ArgumentException();
        
        var expected = Record.Exception(() => new Spdx3Exception("Something bad happened", innerException));
        
        Assert.Null(expected);
    }
}