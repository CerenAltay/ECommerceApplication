using BusinessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        protected readonly ECommerceAppContext context;
        public CategoryRepository(ECommerceAppContext context)
        {
            this.context = context;
        }

        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            //   return await context.Set<T>().OrderBy(x => x.Id).ToListAsync();
            return await context.Categories.OrderBy(x => x.Id).ToListAsync();
        }
    }
}
