using HomeWork4._6.Data.Entities;

namespace HomeWork4._6.Repositories.Abstractions
{
    public interface ILocationRepository
    {
        Task<string> AddLocationAsync(string locationName);
        Task<LocationEntity?> GetLocationAsync(string id);
        Task UpdateLocationAsync(LocationEntity location);
        Task DeleteLocationAsync(string id);
    }
}
