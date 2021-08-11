using ECommerceApplication.DataLayer.Entities;
using ECommerceApplication.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Interfaces
{
    public interface IProductRepository : IRepository<Product> 
    {
    }
}
