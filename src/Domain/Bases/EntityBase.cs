using System;

namespace vxTel.Domain.Bases
{
    public abstract class EntityBase : EntityBaseValidator
    {
        public int Id { get; protected set; }
        public Guid Guid { get; protected set; }
        public DateTime CreateAT { get; protected set; }
        public DateTime ChangedAT { get; protected set; }
    }
}