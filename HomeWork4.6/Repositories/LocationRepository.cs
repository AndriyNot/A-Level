using HomeWork4._6.Data;
using HomeWork4._6.Data.Entities;
using HomeWork4._6.Models;
using HomeWork4._6.Repositories.Abstractions;
using HomeWork4._6.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace HomeWork4._6.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LocationRepository(IDbContextWrapper<ApplicationDbContext> dbContextWrapper)
        {
            _dbContext = dbContextWrapper.DbContext;
        }

        public async Task<string> AddLocationAsync(string locationName)
        {
            var location = new LocationEntity()
            {
                Id = Guid.NewGuid().ToString(),
                LocationName = locationName
            };

            _dbContext.Locations.Add(location);
            await _dbContext.SaveChangesAsync();

            return location.Id;
        }

        public async Task<LocationEntity?> GetLocationAsync(string id)
        {
            return await _dbContext.Locations.FindAsync(id);
        }

        public async Task UpdateLocationAsync(LocationEntity location)
        {
            _dbContext.Entry(location).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteLocationAsync(string id)
        {
            var location = await _dbContext.Locations.FindAsync(id);
            if (location != null)
            {
                _dbContext.Locations.Remove(location);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
