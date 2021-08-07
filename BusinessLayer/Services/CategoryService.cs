using BusinessLayer.Interfaces;
using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class CategoryService : ICategoryService
    {
        //private readonly ICategoryRepository _categoryService;
        public Task<IEnumerable<Category>> Get()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Category>> IAbstractService<Category>.Get()
        {
            throw new NotImplementedException();
        }
    }
}
