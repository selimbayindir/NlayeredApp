using NlayeredApp.Application.Abstractions;
using NlayeredApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Persistence.Concretes
{
    public class InMemoryService : IinMemoryService
    {
        public Task<Product> getproduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> getproducts()
            => new List<Product>()
            {
                new Product() { Id = Guid.NewGuid(), Name = "lAPTOP",Price=10,Stock=10,CreatedDate=DateTime.Now },
                new Product() { Id = Guid.NewGuid(), Name = "Masa Lambası",Price=5,Stock=101,CreatedDate=DateTime.Now },
                new Product() { Id = Guid.NewGuid(), Name = "Çiçek",Price=4,Stock=7,CreatedDate=DateTime.Now },
                new Product() { Id = Guid.NewGuid(), Name = "Yo da",Price=5000,Stock=3,CreatedDate=DateTime.Now }
            };
    }
}
