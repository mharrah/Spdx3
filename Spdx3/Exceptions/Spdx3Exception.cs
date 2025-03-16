namespace Spdx3.Exceptions;

/// <summary>
///     Base class for all exceptions created by Spdx3
/// </summary>
public class Spdx3Exception : ApplicationException
{
    public Spdx3Exception(string message) : base(message)
    {
    }

    public Spdx3Exception(string message, Exception innerException) : base(message, innerException)
    {
    }
}