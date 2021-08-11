using ECommerceApplication.BusinessLayer.Interfaces;
using ECommerceApplication.DataLayer.Entities;
using ECommerceApplication.DataLayer.Repositories;

namespace ECommerceApplication.BusinessLayer.Services
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
