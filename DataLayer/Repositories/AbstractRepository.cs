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
    public abstract class AbstractRepository<T, TEntity> : IRepository<T, TEntity> 
        where TEntity : BaseEntity
        where T : class
    {
        protected readonly ECommerceAppContext _context;
        protected DbSet<TEntity> entities;

        protected AbstractRepository(ECommerceAppContext context)
        {
            _context = context;
            entities = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> Get()
        {
            return await entities.ToListAsync();
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await entities.FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task Add(TEntity item)
        {
            var exists = await GetById(item.Id);

            if (exists == null)
            {
                throw new Exception("Entry already exists");
            }

            await _context.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Update(TEntity item)
        {
            var exists = await GetById(item.Id);

            if (exists != null)
            {
                throw new Exception("Item does not exist");
            }

            await _context.SaveChangesAsync();
        }

        public virtual async Task Delete(int id)
        {
            var exists = await GetById(id);

            if (exists != null)
            {
                throw new Exception("Item does not exist");
            }

            _context.Remove(id);
            await _context.SaveChangesAsync();
        }

    }
}
