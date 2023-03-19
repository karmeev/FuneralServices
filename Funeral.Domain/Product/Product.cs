using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Funeral.Domain.Common.Models;

namespace Funeral.Domain.Product
{
    public sealed class Product : AggregateRoot<ProductId>
    {
        public Product(ProductId id) : base(id)
        {
        }
    }
}