using System.Net;

namespace Funeral.Application.Common.Errors
{
    public class DuplicatePhoneException : Exception, IServiceException
    {
        public DuplicatePhoneException() : base()
        {
        }

        public DuplicatePhoneException(string? message) : base(message)
        {
        }

        public DuplicatePhoneException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

        public string ErrorMessage => "Phone already exists. ";
    }
}