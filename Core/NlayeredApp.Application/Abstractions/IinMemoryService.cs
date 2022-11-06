using NlayeredApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Application.Abstractions
{
    public interface IinMemoryService
    {
        List<Product> getproducts();
        Task<Product> getproduct(int id);
    }
}
