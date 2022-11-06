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
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository//imza(uygulanan),Doğrulayıcı
    {
        public CustomerWriteRepository(NlayeredAppDbContext context) : base(context)
        {
        }
    }
}
