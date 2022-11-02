using NlayeredApp.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayeredApp.Domain.Entities
{
    public class Order :BaseEntity
    {
        public int CustomerId { get; set; } //Default Convertion
        public String Description { get; set; }
        public String Address { get; set; }

        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}
