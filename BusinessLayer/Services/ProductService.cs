using BusinessLayer.Interfaces;
using DataLayer.Entities;
using DataLayer.Repositories;
using ECommerceApplication.BusinessLayer.Interfaces;
using ECommerceApplication.DataLayer.Interfaces;

namespace BusinessLayer.Services
{
    public class ProductService : AbstractService<Product>, IProductService
    {
        private readonly IProductRepository _productRepo;

        public ProductService(IProductRepository productRepo) : base(productRepo)
        {
            _productRepo = productRepo;

        }
    }
}