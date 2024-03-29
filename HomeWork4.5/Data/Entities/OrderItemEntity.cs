using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._5.Data.Entities
{
    public class OrderItemEntity
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public int OrderId { get; set; }

        public OrderEntity? Order { get; set; }

        public int ProductId { get; set; }

        public ProductEntity? Product { get; set; }
    }
}
