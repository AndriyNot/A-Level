namespace HomeWork7.Services
{
    using System.Collections.Generic;
    using HomeWork7.Models;

    internal class ProductService
    {
        public static List<Product> CreateProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Apple 5kg", Price = 4.99 },
                new Product { Id = 2, Name = "Bananna 1kg", Price = 2.67 },
                new Product { Id = 3, Name = "oranges 4kg", Price = 7.50 },
                new Product { Id = 4, Name = "milk", Price = 1.99 },
                new Product { Id = 5, Name = "Apple Juice 1L", Price = 1.30 },
                new Product { Id = 6, Name = "Orange Juice 1l", Price = 1.70 },
                new Product { Id = 7, Name = "Steak 1kg", Price = 80.99 },
                new Product { Id = 8, Name = "Cheese 0.2kg", Price = 2.99 },
                new Product { Id = 9, Name = "Coca Cola 0.7L", Price = 1.50 },
                new Product { Id = 10, Name = "Apple 1kg", Price = 0.60 },
                new Product { Id = 11, Name = "Still Water 0.7L", Price = 0.40 },
            };
        }
    }
}
