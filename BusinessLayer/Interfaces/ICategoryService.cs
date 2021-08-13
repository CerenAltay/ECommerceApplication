using ECommerceApplication.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.BusinessLayer.Interfaces
{
    public interface ICategoryService : IAbstractService<Models.Category>
    {
       Task<IEnumerable<Models.Category>> GetCategory();
       Task<Models.Category> GetCategoryById(int id);
       Task AddCategory(Models.Category item);
       Task UpdateCategory(Models.Category item);
       Task DeleteCategory(int id);
    }
}
