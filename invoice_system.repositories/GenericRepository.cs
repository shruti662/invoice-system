using invoice_system.Database;
using invoice_system.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace invoice_system.repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly InvoiceSystemDbContext _DbContext;
        private readonly DbSet<T> _DbSet;

        public GenericRepository(InvoiceSystemDbContext context)
        {
            _DbContext = context;
            _DbSet = _DbContext.Set<T>(); 
        }

        public void Add(T entity)
        {
            _DbSet.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _DbSet.ToList();
        }

        public T GetById(int Id)
        {
            return _DbSet.Find(Id);
        }

        public void Update(T entity)
        {
            _DbSet.Attach(entity);
            _DbContext.Entry(entity).State = EntityState.Modified; 
        }

        public void Delete(T entity)
        {
            _DbSet.Remove(entity);
        }
    }
}
