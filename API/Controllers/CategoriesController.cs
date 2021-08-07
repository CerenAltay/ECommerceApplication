using BusinessLayer.Models;
using DataLayer;
using DataLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ECommerceAppContext context;
        public CategoriesController(ECommerceAppContext context)
        {
            this.context = context;
        }

        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            return await context.Categories.OrderBy(x => x.Id).ToListAsync();
        }
    }
}
