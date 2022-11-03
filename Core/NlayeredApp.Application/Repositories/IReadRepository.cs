using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Application.Repositories
{
    public interface IReadRepository<T>: IRepository<T> where T : class //t t olsun :)
    {

    }
}
