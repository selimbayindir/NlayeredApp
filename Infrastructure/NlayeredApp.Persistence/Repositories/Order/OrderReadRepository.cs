using NlayeredApp.Application.Repositories;
using NlayeredApp.Domain.Entities;
using NlayeredApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Persistence.Repositories//clear .Order
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository//imza(uygulanan),Doğrulayıcı
    {
        public OrderReadRepository(NlayeredAppDbContext context) : base(context)
        {
        }
    }
}
