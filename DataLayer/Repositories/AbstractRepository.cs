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
    public abstract class AbstractRepository<T> : IRepository<T>
        where T : DbEntity
    {
        protected readonly ECommerceAppContext _context;
        protected DbSet<T> entities;

        protected AbstractRepository(ECommerceAppContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }
        public virtual async Task Add(T item)
        {
            var existingItem = _context.Set<T>().FirstOrDefaultAsync(x => x.Id == item.Id);
            if (existingItem != null)
            {
                throw new Exception("item already exists");
            }

            await _context.Set<T>().AddAsync(item);

            await _context.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> Get()
        {
            return await entities.ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

        }

        public virtual async Task Update(T item)
        {
            var existingItem = _context.Set<T>().FirstOrDefaultAsync(x => x.Id == item.Id);
            if (existingItem == null)
            {
                throw new Exception("item does not exist");
            }

             _context.Update(existingItem);

            await _context.SaveChangesAsync();
        }

        public virtual async Task Delete(int id)
        {
            var existingItem = _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            if (existingItem == null)
            {
                throw new Exception("item does not exist");
            }

            _context.Remove(existingItem);

            await _context.SaveChangesAsync();
        }

    }
}
