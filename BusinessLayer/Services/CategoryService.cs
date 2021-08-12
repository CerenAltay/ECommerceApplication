using ECommerceApplication.BusinessLayer.Interfaces;
using ECommerceApplication.BusinessLayer;
using ECommerceApplication.DataLayer.Entities;
using ECommerceApplication.DataLayer.Interfaces;
using ECommerceApplication.DataLayer.Repositories;
using AutoMapper;

namespace ECommerceApplication.BusinessLayer.Services
{
    public class CategoryService : AbstractService<Category, Models.Category>, ICategoryService
    {
        // private readonly ICategoryRepository _categoryRepo;

        //public CategoryService(ICategoryRepository categoryRepo)
        //{
        //    categoryRepo = _categoryRepo;
        //}
        //public CategoryService(ICategoryRepository categoryRepo) : base(categoryRepo)
        //{
        //    _categoryRepo = categoryRepo;

        //}
        public CategoryService(IRepository<Category> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
