using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NlayeredApp.Application.Repositories;
using NlayeredApp.Domain.Entities;

namespace NlayeredApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository = null)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpPost]
        public async void addproducts()
        {
          await  _productWriteRepository.CreateAsync(new List<Product>
            {
                new() {Id=Guid.NewGuid(),Name="Product1",Price=100,CreatedDate=DateTime.UtcNow,Stock=10},
                new() {Id=Guid.NewGuid(),Name="Product2",Price=100,CreatedDate=DateTime.UtcNow,Stock=20},
                new() {Id=Guid.NewGuid(),Name="Product3",Price=100,CreatedDate=DateTime.UtcNow,Stock=130},
            });
         var count=  await _productWriteRepository.SaveAsync();
        }
    }
}
