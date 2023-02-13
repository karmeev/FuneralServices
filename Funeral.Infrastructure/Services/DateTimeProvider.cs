using Funeral.Application.Services;

namespace Funeral.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow {get;}
    }
}