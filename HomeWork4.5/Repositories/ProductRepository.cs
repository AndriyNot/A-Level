using HomeWork4._5.Data.Entities;
using HomeWork4._5.Data;
using HomeWork4._5.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using HomeWork4._5.Service.Abstractions;

namespace HomeWork4._5.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(
            IDbContextWrapper<ApplicationDbContext> dbContextWrapper)
        {
            _dbContext = dbContextWrapper.DbContext;
        }

        public async Task<int> AddProductAsync(string name, double price)
        {
            var product = new ProductEntity()
            {
                Name = name,
                Price = price
            };

            var result = await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();

            return result.Entity.Id;
        }

        public async Task<ProductEntity?> GetProductAsync(int id)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task UpdateProductAsync(ProductEntity product)
        {
            _dbContext.Products.Update(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(f => f.Id == id);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ProductEntity>> GetFilteredProductsAsync(string nameFilter, double? priceFilter, int pageSize)
        {
            var query = _dbContext.Products.AsQueryable();

            
            if (!string.IsNullOrWhiteSpace(nameFilter))
            {
                query = query.Where(p => p.Name.Contains(nameFilter));
            }

            if (priceFilter.HasValue)
            {
                query = query.Where(p => p.Price <= priceFilter.Value);
            }

            return await query.Take(pageSize).ToListAsync();
        }
    }
}
