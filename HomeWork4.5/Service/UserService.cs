using HomeWork4._5.Data;
using HomeWork4._5.Data.Entities;
using HomeWork4._5.Models;
using HomeWork4._5.Repositories.Abstractions;
using HomeWork4._5.Service.Abstractions;
using Microsoft.Extensions.Logging;

namespace HomeWork4._5.Service
{
    public class UserService : BaseDataService<ApplicationDbContext>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly INotificationService _notificationService;
        private readonly ILogger<UserService> _loggerService;

        public UserService(
            IDbContextWrapper<ApplicationDbContext> dbContextWrapper,
            ILogger<BaseDataService<ApplicationDbContext>> logger,
            IUserRepository userRepository,
            INotificationService notificationService,
            ILogger<UserService> loggerService)
            : base(dbContextWrapper, logger)
        {
            _userRepository = userRepository;
            _notificationService = notificationService;
            _loggerService = loggerService;
        }

        public async Task<string> AddUser(string firstName, string lastName)
        {
            return await ExecuteSafeAsync(async () =>
            {
                var id = await _userRepository.AddUserAsync(firstName, lastName);
                _loggerService.LogInformation($"Created user with Id = {id}");
                var notifyMassage = "registration was successful";
                var notifyTo = "user@gmail.com";
                _notificationService.Notify(NotifyType.Email, notifyMassage, notifyTo);
                return id;
            });
        }

        public async Task<User> GetUser(string id)
        {
            var user = await _userRepository.GetUserAsync(id);

            if (user == null)
            {
                _loggerService.LogWarning($"Not founded user with Id = {id}");
                return null!;
            }

            return new User()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                FullName = $"{user.FirstName} {user.LastName}"
            };
        }

        public async Task UpdateUserAsync(UserEntity user)
        {
            await _userRepository.UpdateUserAsync(user);
        }

        public async Task DeleteUserAsync(string id)
        {
            await _userRepository.DeleteUserAsync(id);
        }
    }
}
