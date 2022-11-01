using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NlayeredApp.Application.Abstractions;
using NlayeredApp.Persistence.Concretes;

namespace NlayeredApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InmemoryController : ControllerBase
    {
        private readonly Application.Abstractions.IinMemoryService _productService;

        public InmemoryController(Application.Abstractions.IinMemoryService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productService.getproducts();
            return Ok(products);
        }
                 
       
    }
}
