﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using vxTel.Domain.Interfaces;
using vxTel.Repository.Context;

namespace vxTel.Repository.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly VxTelContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public RepositoryBase(VxTelContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj) => DbSet.Add(obj);

        public virtual TEntity GetById(Guid id) => DbSet.Find(id);

        public virtual IQueryable<TEntity> GetAll() => DbSet;

        public virtual void Update(TEntity obj) => DbSet.Update(obj);

        public virtual void Remove(Guid id) => DbSet.Remove(DbSet.Find(id));

        public int SaveChanges() => Db.SaveChanges();

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}