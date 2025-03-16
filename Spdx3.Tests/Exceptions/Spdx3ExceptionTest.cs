using Spdx3.Exceptions;

namespace Spdx3.Tests.Exceptions;

public class Spdx3ExceptionTest
{
    [Fact]
    public void Spdx3Exception_InnerException_Can_Be_Supplied()
    {
        Exception innerException = new ArgumentException();

        var expected = Record.Exception(() => new Spdx3Exception("Something bad happened", innerException));

        Assert.Null(expected);
    }
}