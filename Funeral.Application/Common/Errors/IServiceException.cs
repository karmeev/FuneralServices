using System.Net;
namespace Funeral.Application.Common.Errors
{
    public interface IServiceException
    {
        public HttpStatusCode StatusCode { get; }
        public string ErrorMessage { get; }
    }
}