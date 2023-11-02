using Microsoft.AspNetCore.Mvc;
using P06Shop.Shared;
using P06Shop.Shared.Services.ProductService;
using P06Shop.Shared.Shop;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            //try
            //{
            //    var result = await _productService.GetProductsAsync();
            //    return Ok(result);
            //}
            //catch (Exception ex )
            //{
            //    return StatusCode(500, $"Internal server error {ex.Message}");
            //}  

            // ukrywanie wewnetrznych bledow 

            var result = await _productService.GetProductsAsync();

            if (result.Success)
                return Ok(result);
            else
                return  StatusCode(500, $"Internal server error {result.Message}");
        }


    }
}
