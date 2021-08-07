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
        //public Task<T> GetById(long id);
        //public Task Delete(long id);
    }
}
