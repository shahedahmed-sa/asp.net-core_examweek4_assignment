using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ostadproduct.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> ImageUrls { get; set; }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Product 1",
                    Description = "Description for product 1",
                    Price = 10.99M,
                    ImageUrls = new List<string>
                    {
                        "https://example.com/images/product1/image1.jpg",
                        "https://example.com/images/product1/image2.jpg"
                    }
                },
                new Product
                {
                    Id = 2,
                    Name = "Product 2",
                    Description = "Description for product 2",
                    Price = 20.99M,
                    ImageUrls = new List<string>
                    {
                        "https://example.com/images/product2/image1.jpg",
                        "https://example.com/images/product2/image2.jpg"
                    }
                }
                // Add more products as needed
            };

            return Ok(products);
        }
    }
}
