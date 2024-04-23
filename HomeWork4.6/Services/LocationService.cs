using HomeWork4._6.Data;
using HomeWork4._6.Data.Entities;
using HomeWork4._6.Repositories.Abstractions;
using HomeWork4._6.Services.Abstractions;
using Microsoft.Extensions.Logging;

namespace HomeWork4._6.Services
{
    public class LocationService : BaseDataService<ApplicationDbContext>, ILocationService
    {
        private readonly ILocationRepository _locationRepository;
       

        public LocationService(IDbContextWrapper<ApplicationDbContext> dbContextWrapper,
            ILogger<BaseDataService<ApplicationDbContext>> logger, ILocationRepository locationRepository) : base(dbContextWrapper, logger)
        {
            _locationRepository = locationRepository;
        }

        public async Task<string> AddLocationAsync(string locationName)
        {
            return await _locationRepository.AddLocationAsync(locationName);
        }

        public async Task<LocationEntity?> GetLocationAsync(string id)
        {
            return await _locationRepository.GetLocationAsync(id);
        }

        public async Task UpdateLocationAsync(LocationEntity location)
        {
            await _locationRepository.UpdateLocationAsync(location);
        }

        public async Task DeleteLocationAsync(string id)
        {
            await _locationRepository.DeleteLocationAsync(id);
        }
    }
}
