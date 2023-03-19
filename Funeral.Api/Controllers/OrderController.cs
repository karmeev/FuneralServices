using Funeral.Contracts.Order;
using Microsoft.AspNetCore.Mvc;

namespace Funeral.Api.Controllers
{
    [Route("host/{hostId}/order")]
    public class OrderController : ApiController
    {
        [HttpPost]
        public IActionResult CreateOrder(
            CreateOrderRequest request,
            string hostId
        )
        {
            return Ok(request);
        }
    }
}