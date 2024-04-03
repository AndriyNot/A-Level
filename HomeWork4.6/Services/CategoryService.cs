using HomeWork4._6.Data;
using HomeWork4._6.Data.Entities;
using HomeWork4._6.Repositories;
using HomeWork4._6.Repositories.Abstractions;
using HomeWork4._6.Services.Abstractions;
using Microsoft.Extensions.Logging;

namespace HomeWork4._6.Services
{
    public class CategoryService : BaseDataService<ApplicationDbContext>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(IDbContextWrapper<ApplicationDbContext> dbContextWrapper,
            ILogger<BaseDataService<ApplicationDbContext>> logger, ICategoryRepository categoryRepository) : base(dbContextWrapper, logger)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<string> AddCategoryAsync(string categoryName)
        {
            return await _categoryRepository.AddCategoryAsync(categoryName);
        }

        public async Task<CategoryEntity?> GetCategoryAsync(string id)
        {
            return await _categoryRepository.GetCategoryAsync(id);
        }

        public async Task UpdateCategoryAsync(CategoryEntity category)
        {
            await _categoryRepository.UpdateCategoryAsync(category);
        }

        public async Task DeleteCategoryAsync(string id)
        {
            await _categoryRepository.DeleteCategoryAsync(id);
        }
    }
}
