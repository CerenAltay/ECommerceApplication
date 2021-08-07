using DataLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> Get();
    }
}