using Funeral.Domain.Common.Models;

namespace Funeral.Domain.Storage
{
    public sealed class StorageId : ValueObject
    {
        public Guid Value { get; }
        private StorageId(Guid value)
        {
            Value = value;
        }

        public static StorageId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}