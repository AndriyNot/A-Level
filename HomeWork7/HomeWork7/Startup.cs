namespace HomeWork7
{
    using System;
    using HomeWork7.Models;
    using HomeWork7.Services;

    internal class Startup
    {
        public void Start() 
        {
            ShopService shopService = new ShopService();
            Console.WriteLine("List of products:");

            foreach (Product product in shopService.GetProducts())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Id:{product.Id},Product Name:{product.Name},Price:{product.Price}$");
                Console.ResetColor();
            }

            do
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter the product Id to add to the Basket(enter 0 to place the order).");
                Console.ResetColor();

                int productId = Convert.ToInt32(Console.ReadLine());

                if (productId >= 1 && productId <= 11)
                {
                    shopService.AddProduct(productId);
                }
                else if (productId == 0)
                {
                    shopService.GetBill();

                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The product with this ID was not found.");
                    Console.ResetColor();
                }
            } while (true);
        }
    }
}
