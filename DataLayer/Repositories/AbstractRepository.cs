using DataLayer.Entities;
using DataLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public abstract class AbstractRepository<T>: IRepository<T> where T : class
    {
        private readonly ECommerceAppContext context;
        private DbSet<T> entities;

        public AbstractRepository(ECommerceAppContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> Get()
        {
            //   return await context.Set<T>().OrderBy(x => x.Id).ToListAsync();
            //return await entities.OrderBy(x => x.Id).ToListAsync();
            return await entities.ToListAsync();
        }
    }
}
