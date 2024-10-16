﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Entities
{
   public class Product : DbEntity
    {
        public required string Name { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public double Price { get; set; }

        public int CategoryId { get; set; }

        public required virtual Category Category { get; set; }
    }
}
