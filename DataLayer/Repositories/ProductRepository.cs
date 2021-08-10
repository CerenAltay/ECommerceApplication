using DataLayer;
using DataLayer.Entities;
using ECommerceApplication.DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        protected readonly ECommerceAppContext context;
        public ProductRepository(ECommerceAppContext context)
        {
            this.context = context;
        }

        //public async Task<IEnumerable<Product>> Get()
        //{
        //    return await context.Products.OrderBy(x => x.Id).ToListAsync();
        //}
    }
}
