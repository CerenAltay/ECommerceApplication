using ECommerceApplication.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Category : DbEntity
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
