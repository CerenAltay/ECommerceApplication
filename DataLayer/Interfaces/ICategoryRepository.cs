using ECommerceApplication.DataLayer.Entities;
using ECommerceApplication.DataLayer.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        //Task<IEnumerable<Category>> Get();
    }
}