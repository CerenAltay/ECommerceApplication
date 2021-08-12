using ECommerceApplication.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Interfaces
{
    public interface IRepository<T> 
        where T : DbEntity

    {
        public Task<IEnumerable<T>> Get();
        public Task<T> GetById(int id);
        public Task Add(T item);
        public Task Update(T item);
        public Task Delete(int id);
    }
}
