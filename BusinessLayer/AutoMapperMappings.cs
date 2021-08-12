using AutoMapper;
using ECommerceApplication.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.BusinessLayer
{
    public class AutoMapperMappings : Profile
    {
        public AutoMapperMappings()
        {
            CreateMap<Models.Category, Category>();
            CreateMap<Category, Models.Category>();
            CreateMap<Models.Product, Product>();
            CreateMap<Product, Models.Product>();
            CreateMap<Models.Order, Order>();
            CreateMap<Order, Models.Order>();
            CreateMap<Models.Page, Page>();
            CreateMap<Page, Models.Page>();
        }
    }
}
