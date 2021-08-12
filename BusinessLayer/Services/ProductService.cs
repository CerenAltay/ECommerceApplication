using ECommerceApplication.DataLayer.Repositories;
using ECommerceApplication.DataLayer.Interfaces;
using ECommerceApplication.BusinessLayer.Interfaces;
using ECommerceApplication.DataLayer.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

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