namespace Divar.Core.Exceptions;

public class StatusCodeException : Exception
{
    public StatusCodeException()
    {
    }

    public StatusCodeException(string? message) : base(message)
    {
    }
}
