using ECommerceApplication.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{ 
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
