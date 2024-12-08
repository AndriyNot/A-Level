using HomeWork4._6.Data;
using HomeWork4._6.Data.Entities;
using HomeWork4._6.DTOs;
using HomeWork4._6.Models;
using HomeWork4._6.Repositories.Abstractions;
using HomeWork4._6.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace HomeWork4._6.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PetRepository(IDbContextWrapper<ApplicationDbContext> dbContextWrapper) 
        {
            _dbContext = dbContextWrapper.DbContext;
        }

        public async Task<string> AddPetAsync(string name, string categoryId, string breedId, int age, string locationId, string imageUrl, string description)
        {
            
            var pet = new PetEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                CategoryId = categoryId,
                BreedId = breedId,
                Age = age,
                LocationId = locationId,
                ImageUrl = imageUrl,
                Description = description
            };

            await _dbContext.Pets.AddAsync(pet);
            await _dbContext.SaveChangesAsync();

            return pet.Id;
        }

        public async Task<PetEntity?> GetPetAsync(string id)
        {
            return await _dbContext.Pets.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdatePetAsync(PetEntity pet)
        {
            _dbContext.Pets.Update(pet);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeletePetAsync(string id)
        {
            var pet = await _dbContext.Pets.FirstOrDefaultAsync(p => p.Id == id);
            if (pet != null)
            {
                _dbContext.Pets.Remove(pet);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<UniqueBreedDto>> GetUniqueBreedsWithAgeOver3InLocationAsync(string locationName)
        {
            var result = await _dbContext.Pets
                .Include(p => p.Breed)
                .Include(p => p.Category)
                .Where(p => p.Age > 3 && p.Location.LocationName == locationName)
                .GroupBy(p => new { p.Category.CategoryName, p.Breed.BreedName })
                .Select(g => new UniqueBreedDto
                {
                    CategoryName = g.Key.CategoryName,
                    BreedName = g.Key.BreedName,
                    Count = g.Count()
                })
                .ToListAsync();

            return result;
        }

    }
}
