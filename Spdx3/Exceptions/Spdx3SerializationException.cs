namespace Spdx3.Exceptions;

public class Spdx3SerializationException : Spdx3Exception
{
    public Spdx3SerializationException(string message) : base(message)
    {
    }

    public Spdx3SerializationException(string message, Exception innerException) : base(message, innerException)
    {
    }
}