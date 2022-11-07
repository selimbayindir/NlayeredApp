using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NlayeredApp.Domain.Entities;
using NlayeredApp.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Persistence.Context
{
    public class NlayeredAppDbContext : DbContext
    {
        public NlayeredAppDbContext(DbContextOptions options) : base(options)
        {
            //IOC DE DOLACAK
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //interceptor
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker :Entity ler üzerinden yapılan değişikliklerin veya yeni eklenen verileri yakalamamızı sağlayan propertydir. 
           var datas= ChangeTracker.Entries<BaseEntity>();
            foreach (var item in datas)
            {
                 _ = item.State switch
                {
                    EntityState.Added => item.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => item.Entity.UpdatedDate = DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
