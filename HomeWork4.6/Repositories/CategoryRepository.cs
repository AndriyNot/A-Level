using HomeWork4._6.Data;
using HomeWork4._6.Data.Entities;
using HomeWork4._6.Repositories.Abstractions;
using HomeWork4._6.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace HomeWork4._6.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryRepository(IDbContextWrapper<ApplicationDbContext> dbContextWrapper)
        {
            _dbContext = dbContextWrapper.DbContext;
        }

        public async Task<string> AddCategoryAsync(string categoryName)
        {
            var category = new CategoryEntity()
            {
                Id = Guid.NewGuid().ToString(),
                CategoryName = categoryName
            };

            await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();

            return category.Id;
        }

        public async Task<CategoryEntity?> GetCategoryAsync(string id)
        {
            return await _dbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task UpdateCategoryAsync(CategoryEntity category)
        {
            _dbContext.Categories.Update(category);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(string id)
        {
            var category = await _dbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category != null)
            {
                _dbContext.Categories.Remove(category);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}

