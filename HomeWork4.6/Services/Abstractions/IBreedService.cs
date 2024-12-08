using HomeWork4._6.Data.Entities;

namespace HomeWork4._6.Services.Abstractions
{
    public interface IBreedService
    {
        Task<string> AddBreedAsync(string breedName, string categoryId);
        Task<BreedEntity?> GetBreedAsync(string id);
        Task UpdateBreedAsync(BreedEntity breed);
        Task DeleteBreedAsync(string id);
    }
}
