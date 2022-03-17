using eCommerceApp.Application.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
           var products = productService.GetProducts();
            return Ok(products);
        }
    }
}
