using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NlayeredApp.Application.Repositories;
using NlayeredApp.Domain.Entities;
using NlayeredApp.Persistence.Repositories;

namespace NlayeredApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsTestController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        readonly private IOrderReadRepository _orderReadRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;

        readonly private ICustomerWriteRepository _customerWriteRepository;


        public ProductsTestController(
            IProductReadRepository productReadRepository,
            IProductWriteRepository productWriteRepository = null,
            IOrderReadRepository orderReadRepository = null,
            IOrderWriteRepository orderWriteRepository = null,
            ICustomerWriteRepository customerWriteRepository = null)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
        }

        [HttpPost]
        public async Task addproducts()
        {
            // await  _productWriteRepository.CreateAsync(new List<Product>
            //   {
            //       new() {Id=Guid.NewGuid(),Name="Product1",Price=100,CreatedDate=DateTime.UtcNow,Stock=10},
            //       new() {Id=Guid.NewGuid(),Name="Product2",Price=100,CreatedDate=DateTime.UtcNow,Stock=20},
            //       new() {Id=Guid.NewGuid(),Name="Product3",Price=100,CreatedDate=DateTime.UtcNow,Stock=130},
            //   });
            //var count=  await _productWriteRepository.SaveAsync();
            Product product = await _productReadRepository.GetByIdAsync("90A1F136-1B5A-47E8-99DD-DDA074F5131D");
            //tracking false dersen ekleme yapmaz okuma yeterlidir aanlamına gelir
            product.Name = "Sör Resul BAYINDIR";
            await _productWriteRepository.SaveAsync();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
          Product product=await _productReadRepository.GetByIdAsync(id);
            return Ok(product); 
        }

        [HttpGet]
        public async Task OrderTest()
        {
            //interceptor da yaptığımız created ve updated olayını test ettik
            //1
            //var customerId = Guid.NewGuid();
            //await _customerWriteRepository.CreateAsync(new Customer() { Id = customerId,Name="Selim" });
            //_orderWriteRepository.CreateAsync(new List<Order>
            //{
            //    new(){Description="bla bla bla",Address="ISTANBUL,SANCAKTEPE",CustomerId=customerId},
            //    new(){Description="bla bla bla",Address="ISTANBUL,KADIKOY",CustomerId=customerId}
            //});
            //await _orderWriteRepository.SaveAsync();
            //2
          Order order = await _orderReadRepository.GetByIdAsync("19af3180-9e6f-4498-8d69-08dac0f492fe");
            order.Address = "Giresun";
            await _orderWriteRepository.SaveAsync();

    }
}
}
