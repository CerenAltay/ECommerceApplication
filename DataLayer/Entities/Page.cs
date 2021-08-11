using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Entities
{
    public class Page : DbEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
    }
}
