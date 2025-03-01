namespace Spdx3.Exceptions;

/// <summary>
///     Base class for all exceptions created by Spdx3
/// </summary>
public class Spdx3Exception : ApplicationException
{
    internal Spdx3Exception() : base()
    {
        
    }
    
    public Spdx3Exception(string message) : base(message)
    {
        if (string.IsNullOrWhiteSpace(message))
        {
            throw new ArgumentNullException(nameof(message), "The message cannot be null or empty.");
        }
    }

    public Spdx3Exception(string message, Exception innerException) : this(message)
    {
        if (innerException == null)
        {
            throw new ArgumentNullException(nameof(innerException), "The inner exception cannot be null.");
        }
    }
}