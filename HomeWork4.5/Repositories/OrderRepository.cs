using HomeWork4._5.Data.Entities;
using HomeWork4._5.Data;
using HomeWork4._5.Models;
using HomeWork4._5.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using HomeWork4._5.Service.Abstractions;

namespace HomeWork4._5.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderRepository(
            IDbContextWrapper<ApplicationDbContext> dbContextWrapper)
        {
            _dbContext = dbContextWrapper.DbContext;
        }

        public async Task<int> AddOrderAsync(string user, List<OrderItem> items)
        {
            var result = await _dbContext.Orders.AddAsync(new OrderEntity()
            {
                UserId = user
            });

            await _dbContext.OrderItems.AddRangeAsync(items.Select(s => new OrderItemEntity()
            {
                Count = s.Count,
                OrderId = result.Entity.Id,
                ProductId = s.ProductId
            }));

            await _dbContext.SaveChangesAsync();

            return result.Entity.Id;
        }

        public async Task<OrderEntity?> GetOrderAsync(int id)
        {
            return await _dbContext.Orders.Include(i => i.OrderItems).FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<IEnumerable<OrderEntity>?> GetOrderByUserIdAsync(string id)
        {
            return await _dbContext.Orders.Include(i => i.OrderItems).Where(f => f.UserId == id).ToListAsync();
        }

        public async Task UpdateOrderAsync(OrderEntity order)
        {
            _dbContext.Orders.Update(order);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(int id)
        {
            var order = await _dbContext.Orders.FirstOrDefaultAsync(f => f.Id == id);
            if (order != null)
            {
                _dbContext.Orders.Remove(order);
                await _dbContext.SaveChangesAsync();
            }
        }

    }
}
