using Funeral.Domain.Order;

namespace Funeral.Contracts.Order
{
    public record CreateOrderResponse(
                     Guid Id,
                     OtherInformation otherInformation,
                     DateTime lifeDate,
                     DateTime deadDate,
                     string polish,
                     string annex,
                     string adress,
                     string phone,
                     string deliveryAdress,
                     int orderPrice,
                     int prepayment,
                     int reminder,
                     int sellerProcent,
                     DateTime createdDateTime,
                     DateTime updatedDateTime
    );
}