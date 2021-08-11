using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Entities
{
    public class Order : DbEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Cart { get; set; }
        public decimal Total { get; set; }
    }
}
