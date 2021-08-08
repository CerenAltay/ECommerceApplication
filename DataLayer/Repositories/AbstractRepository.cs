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
        protected readonly ECommerceAppContext context;
        protected DbSet<T> entities;

        protected AbstractRepository(ECommerceAppContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> Get()
        {
            return await entities.ToListAsync();
        }
    }
}
