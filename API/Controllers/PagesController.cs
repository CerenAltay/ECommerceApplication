using ECommerceApplication.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        private readonly IPageService _service;
        public PagesController(IPageService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetPage()
        {
            var pages = await _service.Get();
            if (!pages.Any())
            {
                return NoContent();
            }
            return Ok(pages);
        }
    }
}
