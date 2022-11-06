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
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository//imza(uygulanan),Doğrulayıcı
    {
        public ProductReadRepository(NlayeredAppDbContext context) : base(context)
        {
        }
    }
}
