using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._5.Data.Entities
{
    public class UserEntity
    {
        public string Id { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public List<OrderEntity> Orders { get; set; } = new List<OrderEntity>();
    }
}
