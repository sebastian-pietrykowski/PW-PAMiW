using Bogus;
using P06Shop.Shared.Shop;

namespace P07Shop.DataSeeder
{
    public class ProductSeeder
    {
        public static List<Product> GenerateProductData()
        {
            int productId = 1;
            var productFaker = new Faker<Product>()
                .RuleFor(x=>x.Title, x=>x.Commerce.ProductName())
                .RuleFor(x => x.Description, x => x.Commerce.ProductDescription())
                .RuleFor(x=>x.Id, x=> productId++);

            return productFaker.Generate(10).ToList();

        }
    }
}