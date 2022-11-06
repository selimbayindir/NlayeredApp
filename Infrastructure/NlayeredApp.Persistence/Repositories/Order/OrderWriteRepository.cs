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
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository//imza(uygulanan),Doğrulayıcı
    {
        public OrderWriteRepository(NlayeredAppDbContext context) : base(context)
        {
        }
    }
}
