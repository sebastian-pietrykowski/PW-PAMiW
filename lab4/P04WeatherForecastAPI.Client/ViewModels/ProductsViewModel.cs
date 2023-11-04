using CommunityToolkit.Mvvm.ComponentModel;
using P04WeatherForecastAPI.Client.Models;
using P04WeatherForecastAPI.Client.Services.WeatherServices;
using P06Shop.Shared.Services.ProductService;
using P06Shop.Shared.Shop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public partial class ProductsViewModel : ObservableObject
    {
        private readonly IProductService _productService;

        public ObservableCollection<Product> Products { get; set; }

        public ProductsViewModel(IProductService productService)
        {
            _productService = productService;
            Products = new ObservableCollection<Product>();          
        }

        public async void GetProducts()
        {
            var productsResult = await _productService.GetProductsAsync();
            if (productsResult.Success)
            {
                foreach (var p in productsResult.Data)
                {
                    Products.Add(p);
                }
            }
        }

    }
}
