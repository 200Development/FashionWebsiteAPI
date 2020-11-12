using System;
using System.Collections.Generic;
using FashionWebsite.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FashionWebsite.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public Product AddProduct(Product product)
        {
            try
            {
                return new Product();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("getAllProducts")]
        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>();
            var product1 = new Product
            {
                ProductId = 1,
                ProductName = "Baby Shoes 1",
                Description = "Description of baby shoes 1",
                UnitPrice = 54.33m,
                ImageUrl = "assets/jordan-1-baby-crib-bootie-0ZXFgC-removebg-preview.png",
                AvailableInventory = 12
            };
            products.Add(product1);

            var product2 = new Product
            {
                ProductId = 2,
                ProductName = "Baby Shoes 2",
                Description = "Description of baby shoes 2",
                UnitPrice = 22.59m,
                ImageUrl = "assets/white_sneakers-removebg-preview.png",
                AvailableInventory = 12
            };
            products.Add(product2);

            var product3 = new Product
            {
                ProductId = 3,
                ProductName = "Baby Shoes 3",
                Description = "Description of baby shoes 3",
                UnitPrice = 34.99m,
                ImageUrl = "assets/white_sneakers-removebg-preview.png",
                AvailableInventory = 12
            };
            products.Add(product2);

            return products;
        }
    }
}
