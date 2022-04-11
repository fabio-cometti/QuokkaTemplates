namespace Quokka.Templates.Domain.Exceptions
{
    [Serializable]
    public class DomainException : ApplicationException
    {
        public DomainException() : base()
        {
        }

        public DomainException(string? message) : base(message)
        {
        }

        public DomainException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
