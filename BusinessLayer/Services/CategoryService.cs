using BusinessLayer.Interfaces;
using DataLayer.Entities;
using DataLayer.Repositories;

namespace BusinessLayer.Services
{
    public class CategoryService : AbstractService<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;

        public CategoryService(ICategoryRepository categoryRepo) : base(categoryRepo)
        {
            _categoryRepo = categoryRepo;

        }
    }
}
