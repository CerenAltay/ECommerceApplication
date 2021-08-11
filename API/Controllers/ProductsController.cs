using ECommerceApplication.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ECommerceApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            var products = await _service.Get();
            if (!products.Any())
            {
                return NoContent();
            }
            return Ok(products);
        }
    }
}
