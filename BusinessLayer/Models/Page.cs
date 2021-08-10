using ECommerceApplication.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Page : BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
    }
}
