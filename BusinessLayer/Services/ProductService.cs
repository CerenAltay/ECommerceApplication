using ECommerceApplication.BusinessLayer.Interfaces;
using ECommerceApplication.DataLayer.Entities;
using ECommerceApplication.DataLayer.Repositories;
using ECommerceApplication.DataLayer.Interfaces;

namespace ECommerceApplication.BusinessLayer.Services
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