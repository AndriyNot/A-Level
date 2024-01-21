using HomeWork7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7.Models
{
    internal class Basket
    {
        public static List<Product> SelectedProducts = new List<Product>();

        public static void AddProductToBasket(Product product) 
        {
          SelectedProducts.Add(product);
        }

        internal void ViewBasket()
        {
            if (SelectedProducts.Count == 0)
            {
                Console.WriteLine("The basket is empty.");
            }
            else
            {
                Console.WriteLine("Basket Contents:");
                foreach (var product in SelectedProducts)
                {
                    Console.WriteLine($"- {product.Name} (${product.Price})");
                }
            }
        }

    }
}
