using HomeWork4._5.Data.Entities;
using HomeWork4._5.Models;

namespace HomeWork4._5.Service.Abstractions
{
    public interface IOrderService
    {
        Task<int> AddOrderAsync(string user, List<OrderItem> items);
        Task<Order> GetOrderAsync(int id);
        Task<IReadOnlyList<Order>> GetOrderByUserIdAsync(string id);
        Task UpdateOrderAsync(OrderEntity user);
        Task DeleteOrderAsync(int id);
    }
}
