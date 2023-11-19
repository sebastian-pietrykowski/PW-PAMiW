using Microsoft.EntityFrameworkCore;
using P05Shop.API.Models;
using P06Shop.Shared;
using P06Shop.Shared.Services.ProductService;
using P06Shop.Shared.Shop;
using P07Shop.DataSeeder;

namespace P05Shop.API.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;
        public ProductService(DataContext context)
        {
            _dataContext = context;
        }

        public async Task<ServiceResponse<Product>> CreateProductAsync(Product product)
        {
            // try
            // {
            //     _dataContext.Products.Add(product);
            //     await _dataContext.SaveChangesAsync();
            //     return new ServiceResponse<Product>() { Data = product, Success = true };
            // }
            // catch (Exception)
            // {
            //     return new ServiceResponse<Product>()
            //     {
            //         Data = null,
            //         Success = false,
            //         Message = "Cannot create product"
            //     };
            // }
            return null;
        }

        public async Task<ServiceResponse<bool>> DeleteProductAsync(int id)
        {
            // sposób 1 (najpierw znajdujemy potem go usuwamy): 
            //var productToDelete = _dataContext.Products.FirstOrDefault(x => x.Id == id);
            //_dataContext.Products.Remove(productToDelete);  

            // sposób 2: (uzywamy attach : tylko jedno zapytanie do bazy)
            // var product = new Product() { Id = id };
            // _dataContext.Products.Attach(product);
            // _dataContext.Products.Remove(product);
            // await _dataContext.SaveChangesAsync();

            // return new ServiceResponse<bool>() {  Data = true, Success = true };
            return null;
        }

        public async Task<ServiceResponse<Product>> GetProductByIdAsync(int id)
        {
            // try
            // {
            //     var product = await _dataContext.Products.FindAsync(id);
            //     var response = new ServiceResponse<Product>()
            //     {
            //         Data = product,
            //         Message = "Ok",
            //         Success = true
            //     };

            //     return response;
            // }
            // catch (Exception)
            // {
            //     return new ServiceResponse<Product>()
            //     {
            //         Data = null,
            //         Message = "Problem with database",
            //         Success = false
            //     };
            // }
            return null;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            // var products = await _dataContext.Products.ToListAsync();

            // try
            // {
            //     var response = new ServiceResponse<List<Product>>()
            //     {
            //         Data = products,
            //         Message = "Ok",
            //         Success = true
            //     };

            //     return response;
            // }
            // catch (Exception)
            // {
            //     return new  ServiceResponse<List<Product>>()
            //     {
            //         Data = null,
            //         Message = "Problem with database",
            //         Success = false
            //     };
            // }
           return null;
        }

        public async Task<ServiceResponse<Product>> UpdateProductAsync(Product product)
        {
            // try
            // {
            //     var productToEdit = new Product() { Id = product.Id };
            //     _dataContext.Products.Attach(productToEdit);

            //     productToEdit.Title = product.Title;
            //     productToEdit.Description = product.Description;
            //     productToEdit.Price = product.Price;
            //     productToEdit.Barcode = product.Barcode;
            //     productToEdit.ReleaseDate = product.ReleaseDate;

            //     await _dataContext.SaveChangesAsync();
            //     return new ServiceResponse<Product> { Data = productToEdit, Success = true };
            // }
            // catch (Exception)
            // {
            //     return new ServiceResponse<Product>
            //     {
            //         Data = null,
            //         Success = false,
            //         Message = "An error occured while updating product"
            //     };
            // }
            return null;
        }
    }
}
