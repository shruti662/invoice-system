
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice_system.Repositories.Contracts
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
