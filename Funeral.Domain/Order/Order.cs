using Funeral.Domain.Common.Models;
using Funeral.Domain.Host.ValueObjects;
using Funeral.Domain.Storage;
using Funeral.Domain.User;

namespace Funeral.Domain.Order
{
    public sealed class Order : AggregateRoot<OrderId>
    {
        public Order(UserId userId,
                     OrderId orderId,
                     string otherInformation,
                     StorageId storageId,
                     int orderPrice,
                     int prepayment,
                     int reminder,
                     int sellerProcent,
                     DateTime createdDateTime,
                     DateTime updatedDateTime,
                     HostId hostId) : base(orderId)
        {
            UserId = userId;
            OtherInformation = otherInformation;
            StorageId = storageId;
            OrderPrice = orderPrice;
            Prepayment = prepayment;
            Reminder = reminder;
            SellerProcent = sellerProcent;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
            HostId = hostId;
        }

        public UserId UserId { get; }
        public HostId HostId { get; }
        public string OtherInformation { get; }
        public StorageId StorageId { get; }
        public int OrderPrice { get; }
        public int Prepayment { get; }
        public int Reminder { get; }
        public int SellerProcent { get; }
        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }

        public static Order Create(
            UserId userId,
            string otherInformation,
            StorageId storageId,
            int orderPrice,
            int prepayment,
            int reminder,
            int sellerProcent,
            HostId hostId)
        {
            return new(
                userId,
                OrderId.CreateUnique(),
                otherInformation,
                storageId,
                orderPrice,
                prepayment,
                reminder,
                sellerProcent,
                DateTime.Now,
                DateTime.Now,
                hostId
            );
        }
        /*
        public static void AddOrder(Order order)
        {
        }
        public static void UpdateOrder(Order order)
        {
        }
        */
    }
}