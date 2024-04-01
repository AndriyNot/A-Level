using HomeWork4._5.Data.Entities;
using HomeWork4._5.Models;

namespace HomeWork4._5.Service.Abstractions
{
    public interface IUserService
    {
        Task<string> AddUser(string firstName, string lastName);
        Task<User> GetUser(string id);
        Task UpdateUserAsync(UserEntity user);
        Task DeleteUserAsync(string id);
    }
}
