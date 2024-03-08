using HomeWork4._1.Config;
using HomeWork4._1.Dtos;
using HomeWork4._1.Dtos.Responses;
using HomeWork4._1.Requests;
using HomeWork4._1.Services.Abstarctions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HomeWork4._1.Services
{
    public class UserService : IUserService
    {
         
        private readonly IInternalHttpClientService _httpClientService;
        private ILogger<UserService> _logger;
        private readonly ApiOption _options;
        private readonly string _userApi = "api/users/";
        private readonly string _userApi2 = "api/unknown/";
        private readonly string _registerApi = "api/register/";
        private readonly string _loginApi = "api/login/";

        public UserService(IInternalHttpClientService httpClientService, ILogger<UserService> logger, IOptions<ApiOption> options)
        {
            _httpClientService = httpClientService;
            _logger = logger;
            _options = options.Value;
        }


        public async Task<List<UserDto>> ListUsers()
        {
            var result = await _httpClientService.SendAsync<ListUserResponse, object>($"{_options.Host}/api/users?page=1", HttpMethod.Get);

            if (result?.Users != null)
            {
                _logger.LogInformation($"Users were not found");
            }

            return result?.Users;
        }

        public async Task<UserDto> GetUserById(int id)
        {
            var result = await _httpClientService.SendAsync<BaseResponse<UserDto>, object>($"{_options.Host}{_userApi}{id}", HttpMethod.Get);

            if (result?.Data != null)
            {
                _logger.LogInformation($"User with id = {result.Data.Id} was found");
            }

            return result?.Data;
        }

        public async Task<UserDto> SingleUserNotFound(int id)
        {
            var result = await _httpClientService.SendAsync<BaseResponse<UserDto>, object>($"{_options.Host}{_userApi}{id}", HttpMethod.Get);

            if (result != null && result.Data != null)
            {
                _logger.LogInformation($"User with id = {result.Data.Id} was found");
                return result.Data;
            }
            else
            {
                _logger.LogError($"User with id = {id} wasn't found");
                
            }
            
            return null; 
        }

        public async Task<List<ResourceDto>> ListResource()
        {
            var result = await _httpClientService.SendAsync<ListResourceResponse, object>($"{_options.Host}{_userApi2}", HttpMethod.Get);

            if (result?.UsersResource != null)
            {
                _logger.LogInformation($"Users were not found");

            }

            return result?.UsersResource;
        }

        public async Task<ResourceDto> GetResourceById(int id)
        {
            var result = await _httpClientService.SendAsync<BaseResponse<ResourceDto>, object>($"{_options.Host}{_userApi2}{id}", HttpMethod.Get);

            if (result?.Data != null)
            {
                _logger.LogInformation($"User with id = {result.Data.Id} was found");
                
            }

            return result?.Data;
        }

        public async Task<ResourceDto?> SingleResourceNotFound(int id)
        {
            var result = await _httpClientService.SendAsync<BaseResponse<ResourceDto>, object>($"{_options.Host}{_userApi2}{id}", HttpMethod.Get);
            if (result != null && result.Data != null)
            {
                _logger.LogInformation($"User with id = {result.Data.Id} was found");
                return result.Data;
            }
            else
            {
                _logger.LogError($"User with id = {id} wasn't found");
                return null;
            }
        }

        public async Task<UserResponse> CreateUser(string name, string job)
        {
            var result = await _httpClientService.SendAsync<UserResponse, UserRequest>($"{_options.Host}{_userApi}",HttpMethod.Post,
                new UserRequest()
                {
                    Job = job,
                    Name = name
                });

            if (result != null)
            {
                _logger.LogInformation($"User Name:{result.Name},Job:{result.Job},Id:{result.Id},CreatedAt:{result.CreatedAd} was created");
            }

            return result;
        }

        public async Task<UserResponse> UpdateUserPut(int id, string name, string job)
        {
            var request = new UserRequest { Name = name, Job = job };

            var result = await _httpClientService.SendAsync<UserResponse, UserRequest>($"{_options.Host}{_userApi}{id}",
                HttpMethod.Put, 
                request);

            if (result != null)
            {
                _logger.LogInformation($"User with Name:{result.Name},Job:{result.Job},Id:{result.Id},CreatedAt:{result.CreatedAd} was updated Put");
            }

            return result;
        }
        public async Task<UserResponse> UpdateUserPath(int id, string name, string job)
        {
            var request = new UserRequest { Name = name, Job = job };

            var result = await _httpClientService.SendAsync<UserResponse, UserRequest>($"{_options.Host}{_userApi}{id}",
                HttpMethod.Patch, 
                request);

            if (result != null)
            {
                _logger.LogInformation($"User with id = {id} was updated via PATCH.");
            }
            else
            {
                _logger.LogError($"Failed to update user with id = {id}. Result is null.");
                 
            }
            return result;
        }

        public async Task<UserResponse> DeletedUser(int id)
        {

            var result = await _httpClientService.SendAsync<object, object>($"{_options.Host}{_userApi}{id}",
                HttpMethod.Delete);

            if (result != null)
            {
                _logger.LogInformation($"User with id = {id} was deleted");
            }

            return null;
        }

        public async Task<RegisterResponse> RegisterUser(string email, string password)
        {
            var request = new RegisterRequest
            {
                Email = email,
                Password = password
            };

            var result = await _httpClientService.SendAsync<RegisterResponse, RegisterRequest>($"{_options.Host}{_registerApi}",
                HttpMethod.Post, request);

            if (result != null)
            {
                _logger.LogInformation($"User with email = {email} was successfully registered");
            }
            else
            {
                _logger.LogInformation($"Failed to register user with email = {email}");
            }

            return result;
        }

        public async Task<RegisterErrorResponse> RegisterUserError(string email, string password)
        {
            var requestData = new RegisterRequest
            {
                Email = email,
                Password = password
            };

            
              var errorResponse = await _httpClientService.SendAsync<RegisterErrorResponse, RegisterRequest>($"{_options.Host}/api/register",HttpMethod.Post,
                    requestData);

                if (errorResponse != null)
                {
                    _logger.LogError($"Failed to register user with email = {email}. Error: {errorResponse.Error}");
                }
                

                return errorResponse;
            
        }

        public async Task<LoginResponse> Login(string email, string password)
        {
            var requestData = new LoginRequest
            {
                Email = email,
                Password = password
            };

            var response = await _httpClientService.SendAsync<LoginResponse, LoginRequest>(
                $"{_options.Host}{_loginApi}",
                HttpMethod.Post,
                requestData);

            if (response != null)
            {
                _logger.LogInformation($"User with email = {email} logged in successfully");
                return response;
            }
            
                
            return response;
            
        }

        public async Task<RegisterErrorResponse> LoginError(string email, string password)
        {
            var requestData = new LoginRequest
            {
                Email = email,
                Password = password
            };

            var response = await _httpClientService.SendAsync<RegisterErrorResponse, LoginRequest>(
                $"{_options.Host}{_loginApi}",
                HttpMethod.Post,
                requestData);

            if (response != null)
            {
                _logger.LogInformation($"User with email = {email} logged in unsuccessfully.Error: {response.Error}");
                return response;
            }

            return response;

        }

        public async Task<ListUserResponse> GetDelayedResponse()
        {
            var response = await _httpClientService.SendAsync<ListUserResponse, object>($"{_options.Host}/api/users?delay=3",
                HttpMethod.Get);

            return response;
        }

    }
}
