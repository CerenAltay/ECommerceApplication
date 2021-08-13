using ECommerceApplication.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Interfaces
{
    public interface IRepository<T> where T : DbEntity
    {
        Task<IEnumerable<T>> Get();
        Task<T> GetById(int id);
        Task Add(T item);
        Task Update(T item);
        Task Delete(int id);
    }
}
