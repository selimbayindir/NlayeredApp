using NlayeredApp.Application.Repositories;
using NlayeredApp.Domain.Entities;
using NlayeredApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Persistence.Repositories//clear .Customer
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository //imza(uygulanan),Doğrulayıcı
    {
        public CustomerReadRepository(NlayeredAppDbContext context) : base(context)
        {
        }
    }
}
