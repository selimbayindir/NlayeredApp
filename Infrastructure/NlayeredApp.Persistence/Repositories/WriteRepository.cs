using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NlayeredApp.Application.Repositories;
using NlayeredApp.Domain.Entities.Common;
using NlayeredApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly NlayeredAppDbContext _context;

        public WriteRepository(NlayeredAppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> CreateAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }
        public async Task<bool> CreateAsync(List<T> entities)
        {
            await Table.AddRangeAsync(entities);
            return true;
        }
        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }
        public bool Remove(List<T> entities)
        {
             Table.RemoveRange(entities);
            return true;
        }
        public async Task<bool> RemoveByid(string id)
        {
           T model=await Table.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
            return Remove(model);
        }
        public bool Update(T entity)
        {
          EntityEntry<T> entityEntry =Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync()

            => await _context.SaveChangesAsync();

  
    }
}
