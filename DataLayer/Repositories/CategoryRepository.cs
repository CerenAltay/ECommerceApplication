using ECommerceApplication.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApplication.DataLayer.Repositories
{
    public class CategoryRepository : AbstractRepository<Category>, ICategoryRepository
    {

        public CategoryRepository(ECommerceAppContext db) : base(db) { }


    }
}
