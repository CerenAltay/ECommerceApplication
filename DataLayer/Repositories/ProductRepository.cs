﻿using DataLayer;
using DataLayer.Entities;
using DataLayer.Repositories;
using ECommerceApplication.DataLayer.Entities;
using ECommerceApplication.DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Repositories
{
    public class ProductRepository : AbstractRepository<Product, BaseEntity>
    {
        public ProductRepository(ECommerceAppContext context) : base(context) { }

    }
}
