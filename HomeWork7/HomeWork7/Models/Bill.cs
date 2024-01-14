using HomeWork7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7.Models
{
    internal class Bill
    {
        public int IdBill { get; set; }

        public string ShopName { get; set; }

        public DateTime Date {  get; set; }

        public List<Product> basketOfProducts = new List<Product>();

        public double TotalPrice { get; set; }
    }
}
