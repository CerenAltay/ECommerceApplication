using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IAbstractService<T>
    {
        Task<IEnumerable<T>> Get();
        public Task GetById(long id);
        public Task Add(T id);
        public Task Update(T id);
        public Task Delete(T id);
    }
}
