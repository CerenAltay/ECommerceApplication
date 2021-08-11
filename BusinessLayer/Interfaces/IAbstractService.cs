using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.BusinessLayer.Interfaces
{
    public interface IAbstractService<T>
    {
        public Task Add(int id);
        public Task<IEnumerable<T>> Get();
        public Task<T> GetById(int id);
        public Task Update(T item);
        public Task Delete(int id);
    }
}
