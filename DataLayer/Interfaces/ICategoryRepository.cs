using DataLayer.Entities;
using DataLayer.Interfaces;
using ECommerceApplication.DataLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface ICategoryRepository : IRepository<Category, BaseEntity>
    {
        //Task<IEnumerable<Category>> Get();
    }
}