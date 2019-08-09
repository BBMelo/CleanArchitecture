using System;
using System.Linq;

namespace vxTel.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity @object);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity @object);
        void Remove(Guid id);
        int SaveChanges();
    }
}
