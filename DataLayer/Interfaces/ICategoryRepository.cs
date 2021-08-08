using DataLayer.Entities;
using DataLayer.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        //Task<IEnumerable<Category>> Get();
    }
}