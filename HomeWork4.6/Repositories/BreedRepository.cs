using HomeWork4._6.Data;
using HomeWork4._6.Data.Entities;
using HomeWork4._6.Repositories.Abstractions;
using HomeWork4._6.Services.Abstractions;
using Microsoft.EntityFrameworkCore;


namespace HomeWork4._6.Repositories
{
    public class BreedRepository : IBreedRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public BreedRepository(IDbContextWrapper<ApplicationDbContext> dbContextWrapper)
        {
            _dbContext = dbContextWrapper.DbContext;
        }

        public async Task<string> AddBreedAsync(string breedName, string categoryId)
        {
            var breed = new BreedEntity()
            {
                Id = Guid.NewGuid().ToString(),
                BreedName = breedName,
                CategoryId = categoryId
            };

            _dbContext.Breeds.AddAsync(breed);
            await _dbContext.SaveChangesAsync();

            return breed.Id;
        }

        public async Task<BreedEntity?> GetBreedAsync(string id)
        {
            return await _dbContext.Breeds.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task UpdateBreedAsync(BreedEntity breed)
        {
            _dbContext.Breeds.Update(breed);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteBreedAsync(string id)
        {
            var breed = await _dbContext.Breeds.FirstOrDefaultAsync(b => b.Id == id);
            if (breed != null)
            {
                _dbContext.Breeds.Remove(breed);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
