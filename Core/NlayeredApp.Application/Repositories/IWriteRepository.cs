using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Application.Repositories
{
    public interface IWriteRepository<T>: IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(int id);
    }
}
