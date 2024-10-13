using ECommerceApplication.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Repositories
{
    public class CategoryRepository : AbstractRepository<Category>, ICategoryRepository
    {
        //protected readonly ECommerceAppContext context;
        //public CategoryRepository(ECommerceAppContext context)
        //{
        //    this.context = context;
        //}
        public CategoryRepository(ECommerceAppContext db) : base(db) { }

        //public async Task<IEnumerable<Category>> Get()
        //{
        //    return await context.Categories.OrderBy(x => x.Id).ToListAsync();
        //}

    }
}
