﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._5.Models
{
    public class OrderItem
    {
        public int Count { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }
    }
}
