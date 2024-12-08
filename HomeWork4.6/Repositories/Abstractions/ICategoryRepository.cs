using HomeWork4._6.Data.Entities;

namespace HomeWork4._6.Repositories.Abstractions
{
    public interface ICategoryRepository
    {
        Task<string> AddCategoryAsync(string categoryName);
        Task<CategoryEntity?> GetCategoryAsync(string id);
        Task UpdateCategoryAsync(CategoryEntity category);
        Task DeleteCategoryAsync(string id);
    }
}
