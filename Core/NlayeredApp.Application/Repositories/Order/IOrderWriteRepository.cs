using NlayeredApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Application.Repositories//clear .Order
{
    public interface IOrderWriteRepository:IWriteRepository<Order>
    {
    }
}
