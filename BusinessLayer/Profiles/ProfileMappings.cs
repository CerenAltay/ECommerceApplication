using AutoMapper;
using ECommerceApplication.DataLayer.Entities;
using ECommerceApplication.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.BusinessLayer.Profiles
{
    public class ProfileMappings : Profile
    {

        //example mappings/ if needed
        public ProfileMappings()
        {
            CreateMap<Category, Models.Category>();
        }
    }
}
