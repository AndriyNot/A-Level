using HomeWork4._1.Dtos;
using HomeWork4._1.Dtos.Responses;

namespace HomeWork4._1.Services.Abstarctions
{
    public interface IUserService
    {
        Task<List<UserDto>> ListUsers();
        Task<UserDto> GetUserById(int id);
        Task<UserDto> SingleUserNotFound(int id);
        Task<List<ResourceDto>> ListResource();
        Task<ResourceDto> GetResourceById(int id);
        Task<ResourceDto> SingleResourceNotFound(int id);
        Task<UserResponse> CreateUser(string name, string job);
        Task<UserResponse> UpdateUserPut(int id, string name, string job);
        Task<UserResponse> UpdateUserPath(int id, string name, string job);
        Task<UserResponse> DeletedUser(int id);
        Task<RegisterResponse> RegisterUser(string email, string password);
        Task<RegisterErrorResponse> RegisterUserError(string email, string password);
        Task<LoginResponse> Login(string email, string password);
        Task<RegisterErrorResponse> LoginError(string email, string password);
        Task<ListUserResponse> GetDelayedResponse();
    }
}
