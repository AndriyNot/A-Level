using HomeWork4._5.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._5.Models
{
    public class Order
    {
        public int Id { get; set; }

        public UserEntity? User { get; set; }

        public IEnumerable<OrderItem>? OrderItems { get; set; }
    }
}
