using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Funeral.Domain.Common.Models;

namespace Funeral.Domain.Storage
{
    public class Storage : AggregateRoot<StorageId>
    {
        public Storage(StorageId id) : base(id)
        {
        }
    }
}