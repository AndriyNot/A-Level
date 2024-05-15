using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork6._1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 210 },
                new Product { Id = 3, Name = "Product 2", Price = 120 },
                new Product { Id = 23, Name = "Product 3", Price = 5 },
                new Product { Id = 44, Name = "Product 4", Price = 315 },
                new Product { Id = 2, Name = "Product 5", Price = 18 },
                new Product { Id = 11, Name = "Product 6", Price = 10 },
                new Product { Id = 21, Name = "Product 7", Price = 120 },
                new Product { Id = 33, Name = "Product 8", Price = 25 },
                new Product { Id = 10, Name = "Product 9", Price = 115 },
                new Product { Id = 50, Name = "Product 10", Price = 88 }
            };

            return products;
        }
    }
}