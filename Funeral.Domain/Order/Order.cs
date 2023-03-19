using System;

using Funeral.Domain.Common.Models;
using Funeral.Domain.Order;
using Funeral.Domain.Storage;
using Funeral.Domain.User;

namespace Funeral.Domain.Order
{
    public sealed class Order : AggregateRoot<OrderId>
    {
        public Order(UserId userId,
                     OrderId orderId,
                     OtherInformation otherInformation,
                     DateTime lifeDate,
                     DateTime deadDate,
                     StorageId storageId,
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
                     DateTime updatedDateTime) : base(orderId)
        {
            UserId = userId;
            OtherInformation = otherInformation;
            LifeDate = lifeDate;
            DeadDate = deadDate;
            StorageId = storageId;
            Polish = polish;
            Annex = annex;
            Address = address;
            Phone = phone;
            DeliveryAddress = deliveryAddress;
            OrderPrice = orderPrice;
            Prepayment = prepayment;
            Reminder = reminder;
            SellerProcent = sellerProcent;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
        }

        public UserId UserId { get; }
        public OtherInformation OtherInformation { get; }
        public DateTime LifeDate { get; }
        public DateTime DeadDate { get; }
        public StorageId StorageId { get; }
        public string Polish { get; }
        public string Annex { get; }
        public string Address { get; }
        public string Phone { get; }
        public string DeliveryAddress { get; }
        public int OrderPrice { get; }
        public int Prepayment { get; }
        public int Reminder { get; }
        public int SellerProcent { get; }
        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }

        public static Order Create(
            UserId userId,
            OtherInformation otherInformation,
            StorageId storageId,
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
            int sellerProcent)
        {
            return new(
                userId,
                OrderId.CreateUnique(),
                otherInformation,
                lifeDate,
                deadDate,
                storageId,
                polish,
                annex,
                address,
                phone,
                deliveryAddress,
                orderPrice,
                prepayment,
                reminder,
                sellerProcent,
                DateTime.Now,
                DateTime.Now
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
        public OtherInformation AddInformation(
            string obeliskForm,
            string pedestalForm,
            string funeralForm,
            string funeralColor,
            string upPartObelisk,
            string botPartObelisk,
            string otherDesign)
        {
            return new(obeliskForm,
                       pedestalForm,
                       funeralForm,
                       funeralColor,
                       upPartObelisk,
                       botPartObelisk,
                       otherDesign);
        }
    }
}