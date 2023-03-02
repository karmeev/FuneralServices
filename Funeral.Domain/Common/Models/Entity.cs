using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funeral.Domain.Common.Models
{
    public abstract class Entity<TId> : IEquatable<Entity<TId>>
    where TId : notnull
    {
        protected Entity(TId id)
        {
            Id = id;
        }

        public TId Id { get; protected set; }
        public override bool Equals(object obj)
        {
            return obj is Entity<TId> entity && Id.Equals(entity.Id);
        }
        public static bool operator ==(Entity<TId> left, Entity<TId> right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(Entity<TId> left, Entity<TId> right)
        {
            return !Equals(left, right);
        }

        public override bool Equals(Entity<TId> other)
        {
            return Equals((object?)other);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}