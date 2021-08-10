using DataLayer.Entities;
using ECommerceApplication.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class CategoryRepository : AbstractRepository<Category, BaseEntity>
    {
        public CategoryRepository(ECommerceAppContext context) : base(context) { }
 

    }
}
