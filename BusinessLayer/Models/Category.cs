using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.BusinessLayer.Models
{ 
    public class Category : DomainObject
    {
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
