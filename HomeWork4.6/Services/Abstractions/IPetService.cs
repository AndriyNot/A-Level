using HomeWork4._6.Data.Entities;
using HomeWork4._6.DTOs;

namespace HomeWork4._6.Services.Abstractions
{
    public interface IPetService
    {
        Task<string> AddPetAsync(string name, string categoryId, string breedId, int age, string locationId, string imageUrl, string description);
        Task<PetEntity?> GetPetAsync(string id);
        Task UpdatePetAsync(PetEntity pet);
        Task DeletePetAsync(string id);
        Task<List<UniqueBreedDto>> GetUniqueBreedsWithAgeOver3InLocationAsync(string locationName);
    }
}
