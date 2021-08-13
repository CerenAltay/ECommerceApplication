using AutoMapper;
using ECommerceApplication.BusinessLayer.Interfaces;
using ECommerceApplication.BusinessLayer;
using ECommerceApplication.DataLayer.Entities;
using ECommerceApplication.DataLayer.Repositories;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ECommerceApplication.BusinessLayer.Services
{
    public class CategoryService : AbstractService<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepo, IMapper mapper) : base(categoryRepo)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;

        }

        public Task AddCategory(Models.Category category)
        {
            var categories = _mapper.Map<Models.Category, Category>(category);
            return _categoryRepo.Add(categories);

        }


        public Task<IEnumerable<Models.Category>> GetCategory()
        {
            var categories = _categoryRepo.Get();
            var mappedCategories = _mapper.Map<Models.Category, Task<IEnumerable<Category>>>(categories);
            return mappedCategories;
            //var categories = _mapper.Map<Models.Category, Category>(category);
        }

        public Task<Models.Category> GetCategoryById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteCategory(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateCategory(Models.Category item)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<Models.Category>> IAbstractService<Models.Category>.Get()
        {
            throw new System.NotImplementedException();
        }

        Task<Models.Category> IAbstractService<Models.Category>.GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Models.Category item)
        {
            throw new System.NotImplementedException();
        }
    }
}
