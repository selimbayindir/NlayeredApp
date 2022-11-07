
using NlayeredApp.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Domain.Entities
{
    public class Product:BaseEntity
    {
        public Product()
        {
        }

        public Product(string name, int stock, float price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }

        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }

        public ICollection<Order> Orders { get; set; }

    }   
}
