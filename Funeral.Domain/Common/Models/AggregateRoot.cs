using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funeral.Domain.Common.Models
{
    public abstract class AggregateRoot : Entity<TId>
    where TId : notnull
    {
        protected AggregateRoot(TId id) : base (id)
        {
            
        }
    }
}