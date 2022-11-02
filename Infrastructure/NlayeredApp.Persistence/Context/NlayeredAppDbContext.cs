using Microsoft.EntityFrameworkCore;
using NlayeredApp.Domain.Entities;
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
    }
}
