using Funeral.Domain.Common.Models;

namespace Funeral.Domain.Order
{
    public sealed class OrderId : ValueObject
    {
        public Guid Value { get; }

        private OrderId(Guid value)
        {
            Value = value;
        }

        public static OrderId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}