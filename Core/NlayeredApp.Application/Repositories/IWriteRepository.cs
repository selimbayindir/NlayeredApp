using NlayeredApp.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> CreateAsync(T entity);
        Task<bool> CreateAsync(List<T> entities);
        bool Remove(T entity);
        bool Remove(List<T> entities);
        Task<bool> RemoveByid(String id);
        bool Update(T entity);
        Task<int> SaveAsync();
    }
}
