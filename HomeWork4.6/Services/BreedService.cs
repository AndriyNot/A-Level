using HomeWork4._6.Data;
using HomeWork4._6.Data.Entities;
using HomeWork4._6.Repositories.Abstractions;
using HomeWork4._6.Services.Abstractions;
using Microsoft.Extensions.Logging;

namespace HomeWork4._6.Services
{
    public class BreedService : BaseDataService<ApplicationDbContext>, IBreedService
    {
        private readonly IBreedRepository _breedRepository;
        private readonly ILogger<BreedService> _loggerService;

        public BreedService(IDbContextWrapper<ApplicationDbContext> dbContextWrapper,
            ILogger<BaseDataService<ApplicationDbContext>> logger, IBreedRepository breedRepository, ILogger<BreedService> loggerService) : base(dbContextWrapper, logger)
        {
            _breedRepository = breedRepository;
            _loggerService = loggerService;
        }

        public async Task<string> AddBreedAsync(string breedName, string categoryId)
        {
            return await _breedRepository.AddBreedAsync(breedName, categoryId);
        }

        public async Task<BreedEntity?> GetBreedAsync(string id)
        {
            return await _breedRepository.GetBreedAsync(id);
        }

        public async Task UpdateBreedAsync(BreedEntity breed)
        {
            await _breedRepository.UpdateBreedAsync(breed);
        }

        public async Task DeleteBreedAsync(string id)
        {
            await _breedRepository.DeleteBreedAsync(id);
        }
    }
}
