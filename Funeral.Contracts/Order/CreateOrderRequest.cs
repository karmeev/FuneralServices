
using Funeral.Domain.Order;

namespace Funeral.Contracts.Order
{
    public record CreateOrderRequest(
                     string OtherInformation,
                     int OrderPrice,
                     int Prepayment,
                     int Reminder,
                     int SellerProcent,
                     DateTime CreatedDateTime,
                     DateTime UpdatedDateTime
    );
}