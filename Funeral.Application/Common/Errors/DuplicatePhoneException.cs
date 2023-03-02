using System.Net;

namespace Funeral.Application.Common.Errors
{
    public class DuplicatePhoneException : Exception, IServiceException
    {
        public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

        public string ErrorMessage => "Phone already exists. ";
    }
}