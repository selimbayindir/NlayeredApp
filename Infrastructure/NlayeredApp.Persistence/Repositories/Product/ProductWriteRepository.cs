using NlayeredApp.Application.Repositories;
using NlayeredApp.Domain.Entities;
using NlayeredApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Persistence.Repositories//clear .Product
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository//imza(uygulanan),Doğrulayıcı
    {
        public ProductWriteRepository(NlayeredAppDbContext context) : base(context)
        {
        }
    }
}
