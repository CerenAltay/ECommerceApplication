using ECommerceApplication.BusinessLayer.Interfaces;
using ECommerceApplication.BusinessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApplication.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService service)
        {
            _categoryService = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryService.Get();
            if (!categories.Any())
            {
                return NoContent();
            }
            return Ok(categories);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var category = await _categoryService.GetById(id);
            if (category == null)
            {
                return NoContent();
            }
            return Ok(category);
        }
    }
}
