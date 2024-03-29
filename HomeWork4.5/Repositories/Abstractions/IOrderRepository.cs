using HomeWork4._5.Data.Entities;
using HomeWork4._5.Models;

namespace HomeWork4._5.Repositories.Abstractions
{
    public interface IOrderRepository
    {
        Task<int> AddOrderAsync(string user, List<OrderItem> items);
        Task<OrderEntity?> GetOrderAsync(int id);
        Task<IEnumerable<OrderEntity>?> GetOrderByUserIdAsync(string id);
        Task UpdateOrderAsync(OrderEntity order);
        Task DeleteOrderAsync(int id);
    }
}
