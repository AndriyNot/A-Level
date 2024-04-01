using HomeWork4._5.Data.Entities;

namespace HomeWork4._5.Repositories.Abstractions
{
    public interface IProductRepository
    {
        Task<int> AddProductAsync(string name, double price);
        Task<ProductEntity?> GetProductAsync(int id);
        Task UpdateProductAsync(ProductEntity user);
        Task DeleteProductAsync(int id);
        Task<IEnumerable<ProductEntity>> GetFilteredProductsAsync(string nameFilter, double? priceFilter, int pageSize);
    }
}
