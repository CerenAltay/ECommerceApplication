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
    public class ProductRepository : AbstractRepository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceAppContext db) : base(db) { }

        //public async Task<IEnumerable<Product>> Get()
        //{
        //    return await context.Products.OrderBy(x => x.Id).ToListAsync();
        //}
    }
}
