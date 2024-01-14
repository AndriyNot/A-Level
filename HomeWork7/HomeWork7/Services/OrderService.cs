namespace HomeWork7.Services
{
    using System;
    using System.Collections.Generic;
    using HomeWork7.Models;

    internal class OrderService
    {
        public int GenerationOrderId()
        {
            Random random = new Random();  
            return random.Next(100, 1000);
        }

        public double GetTotalPrice(List<Product> products) 
        {
            double totalPrice = 0;

            foreach (Product product in products)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }
    }
}
