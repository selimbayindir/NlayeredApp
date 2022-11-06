using Microsoft.EntityFrameworkCore;
using NlayeredApp.Application.Repositories;
using NlayeredApp.Domain.Entities.Common;
using NlayeredApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly NlayeredAppDbContext _context;

        public ReadRepository(NlayeredAppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()    
            =>Table;
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
            => Table.Where(predicate);
        public async Task<T> GetOneAsync(Expression<Func<T, bool>> predicate)
            =>await Table.FirstOrDefaultAsync(predicate);

        public Task<T> GetByIdAsync(string id)
          => Table.FirstOrDefaultAsync(p => p.Id==  Guid.Parse(id)); //marker işaretleyici tür BaseEntity
    }
}
