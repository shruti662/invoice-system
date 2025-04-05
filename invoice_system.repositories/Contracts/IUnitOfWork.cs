using invoice_system.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice_system.Repositories.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        Task Commit();
    }
}
    