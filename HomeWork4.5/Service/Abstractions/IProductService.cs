using HomeWork4._5.Data.Entities;
using HomeWork4._5.DTOs;
using HomeWork4._5.Models;

namespace HomeWork4._5.Service.Abstractions
{
    public interface IProductService
    {
        Task<int> AddProductAsync(string name, double price);
        Task<Product> GetProductAsync(int id);
        Task UpdateProductAsync(ProductEntity user);
        Task DeleteProductAsync(int id);
        Task<IEnumerable<ProductEntity>> GetFilteredProductsAsync(PageDto pageDto);


    }
}
