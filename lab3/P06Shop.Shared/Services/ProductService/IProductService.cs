using P06Shop.Shared;
using P06Shop.Shared.Shop;

namespace P06Shop.Shared.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
    }
}
