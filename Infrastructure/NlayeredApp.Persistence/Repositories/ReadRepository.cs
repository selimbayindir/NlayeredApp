using Microsoft.EntityFrameworkCore;
using NlayeredApp.Application.Repositories;
using NlayeredApp.Domain.Entities.Common;
using NlayeredApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate, bool tracking = true)
        {
            var query = Table.Where(predicate);
            if (!tracking)
                query = query.AsNoTracking();
            return query;

        }
        public async Task<T> GetOneAsync(Expression<Func<T, bool>> predicate, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
                ///=> Table.FirstOrDefaultAsync(p => p.Id==  Guid.Parse(id)); //marker işaretleyici tür BaseEntity
          //=>await Table.FindAsync(Guid.Parse(id)); //marker işaretleyici tür BaseEntity
          var query =Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
        }

    }
}
