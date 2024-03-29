using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._5.Data.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public double Price { get; set; }

        public List<OrderItemEntity> OrderItems { get; set; } = new List<OrderItemEntity>();
    }
}
