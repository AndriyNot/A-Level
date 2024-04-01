using HomeWork4._5.Data;
using HomeWork4._5.Data.Entities;
using HomeWork4._5.DTOs;
using HomeWork4._5.Models;
using HomeWork4._5.Repositories;
using HomeWork4._5.Repositories.Abstractions;
using HomeWork4._5.Service.Abstractions;
using Microsoft.Extensions.Logging;

namespace HomeWork4._5.Service
{
    public class ProductService : BaseDataService<ApplicationDbContext>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<UserService> _loggerService;

        public ProductService(
            IDbContextWrapper<ApplicationDbContext> dbContextWrapper,
            ILogger<BaseDataService<ApplicationDbContext>> logger,
            IProductRepository productRepository,
            ILogger<UserService> loggerService)
            : base(dbContextWrapper, logger)
        {
            _productRepository = productRepository;
            _loggerService = loggerService;
        }

        public async Task<int> AddProductAsync(string name, double price)
        {
            var id = await _productRepository.AddProductAsync(name, price);
            _loggerService.LogInformation($"Created product with Id = {id}");
            return id;
        }

        public async Task<Product> GetProductAsync(int id)
        {
            var result = await _productRepository.GetProductAsync(id);

            if (result == null)
            {
                _loggerService.LogWarning($"Not founded product with Id = {id}");
                return null!;
            }

            return new Product()
            {
                Id = result.Id,
                Name = result.Name,
                Price = result.Price
            };
        }
        public async Task UpdateProductAsync(ProductEntity user)
        {
            await _productRepository.UpdateProductAsync(user);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteProductAsync(id);
        }

        public async Task<IEnumerable<ProductEntity>> GetFilteredProductsAsync(PageDto pageDto)
        {
            return await _productRepository.GetFilteredProductsAsync(pageDto.Filter.Name, pageDto.Filter.Price, pageDto.PageSize);
        }
    }
}
