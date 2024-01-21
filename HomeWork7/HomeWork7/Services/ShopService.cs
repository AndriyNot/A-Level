namespace HomeWork7.Services
{
    using System;
    using System.Collections.Generic;
    using HomeWork7.Models;

    internal class ShopService
    {
        public void AddProduct(int targetProductId)
        {
            List<Product> products = ProductService.CreateProducts();
            Product foundProduct = null;
            foreach (Product item in products)
            {
                if (item.Id == targetProductId)
                {
                    foundProduct = item;

                }
            }

            Basket.SelectedProducts.Add(foundProduct);
        }

        public List<Product> GetProducts()
        {
            return ProductService.CreateProducts();
        }

        public void GetBasket()
        {
            List<Product> products = Basket.SelectedProducts;
            if (Basket.SelectedProducts.Count == 0)
            {
                Console.WriteLine("The basket is empty");
            }
            else 
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"Id:{product.Id},Product Name:{product.Name},Price:{product.Price}$");
                }
            }
        }

        public void GetBill()
        {
            List<Product> products = Basket.SelectedProducts;
            OrderService orderService = new OrderService();

            int orderId = orderService.GenerationOrderId();
            double totalPrice = orderService.GetTotalPrice(products);
            Bill order = new Bill { IdBill = orderId, ShopName = "ATB", basketOfProducts = products, Date = DateTime.Now, TotalPrice = totalPrice };

            Console.WriteLine("Dear customer, your order has been placed");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Order number:{order.IdBill}, Store number:{order.ShopName}, Order date:{order.Date}, Order price:{order.TotalPrice}$");
            Console.ResetColor();
            Console.WriteLine("List of ordered products");
            this.GetBasket();
        }
    }
}
