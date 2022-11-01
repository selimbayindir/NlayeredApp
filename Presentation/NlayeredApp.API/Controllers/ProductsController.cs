using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NlayeredApp.Application.Abstractions;
using NlayeredApp.Persistence.Concretes;

namespace NlayeredApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
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
