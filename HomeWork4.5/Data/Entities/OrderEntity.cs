using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._5.Data.Entities
{
    public class OrderEntity
    {
        public int Id { get; set; }

        public string? UserId { get; set; }

        public UserEntity? User { get; set; }

        public List<OrderItemEntity> OrderItems { get; set; } = new List<OrderItemEntity>();
    }
}
