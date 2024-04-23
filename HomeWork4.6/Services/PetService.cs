using HomeWork4._6.Data;
using HomeWork4._6.Data.Entities;
using HomeWork4._6.DTOs;
using HomeWork4._6.Repositories.Abstractions;
using HomeWork4._6.Services.Abstractions;
using Microsoft.Extensions.Logging;

namespace HomeWork4._6.Services
{
    public class PetService : BaseDataService<ApplicationDbContext>, IPetService
    {
        private readonly IPetRepository _petRepository;
        

        public PetService(IDbContextWrapper<ApplicationDbContext> dbContextWrapper,
            ILogger<BaseDataService<ApplicationDbContext>> logger, IPetRepository petRepository) : base(dbContextWrapper, logger)
        {
            _petRepository = petRepository;
           
        }

        public async Task<string> AddPetAsync(string name, string categoryId, string breedId, int age, string locationId, string imageUrl, string description)
        {
            var id = await _petRepository.AddPetAsync(name, categoryId, breedId, age, locationId, imageUrl, description);

            return id;
        }

        public async Task<PetEntity?> GetPetAsync(string id)
        {
            return await _petRepository.GetPetAsync(id);
        }

        public async Task UpdatePetAsync(PetEntity pet)
        {
            await _petRepository.UpdatePetAsync(pet);
        }

        public async Task DeletePetAsync(string id)
        {
            await _petRepository.DeletePetAsync(id);
        }

        public async Task<List<UniqueBreedDto>> GetUniqueBreedsWithAgeOver3InLocationAsync(string locationName)
        {
            return await _petRepository.GetUniqueBreedsWithAgeOver3InLocationAsync(locationName);
        }
    }
}
