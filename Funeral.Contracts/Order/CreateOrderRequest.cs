
using Funeral.Domain.Order;

namespace Funeral.Contracts.Order
{
    public record CreateOrderRequest(
                     OtherInformation otherInformation,
                     DateTime lifeDate,
                     DateTime deadDate,
                     string polish,
                     string annex,
                     string address,
                     string phone,
                     string deliveryAddress,
                     int orderPrice,
                     int prepayment,
                     int reminder,
                     int sellerProcent,
                     DateTime createdDateTime,
                     DateTime updatedDateTime
    );
}