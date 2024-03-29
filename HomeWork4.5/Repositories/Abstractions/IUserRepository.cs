using HomeWork4._5.Data.Entities;

namespace HomeWork4._5.Repositories.Abstractions
{
    public interface IUserRepository
    {
        Task<string> AddUserAsync(string firstName, string lastName);
        Task<UserEntity?> GetUserAsync(string id);
        Task UpdateUserAsync(UserEntity user);
        Task DeleteUserAsync(string id);
    }
}
