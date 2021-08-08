using DataLayer.Entities;
using DataLayer.Interfaces;
using ECommerceApplication.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public abstract class AbstractRepository<T> : IRepository<T>
        where T : class 
    {
        protected readonly ECommerceAppContext _context;
        protected DbSet<T> entities;

        protected AbstractRepository(ECommerceAppContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> Get()
        {
            return await entities.ToListAsync();
        }

        //public virtual async Task<T> GetById(int id)
        //{
        //    return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        //    //
        //    //return await entities.Where(x=>x.).FirstOrDefaultAsync();
        //}
    }
}
