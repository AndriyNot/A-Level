using HomeWork4._5.Data.Entities;
using HomeWork4._5.Data;
using HomeWork4._5.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using HomeWork4._5.Service.Abstractions;

namespace HomeWork4._5.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(
            IDbContextWrapper<ApplicationDbContext> dbContextWrapper)
        {
            _dbContext = dbContextWrapper.DbContext;
        }

        public async Task<string> AddUserAsync(string firstName, string lastName)
        {
            var user = new UserEntity()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = firstName,
                LastName = lastName
            };

            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user.Id;
        }

        public async Task<UserEntity?> GetUserAsync(string id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task UpdateUserAsync(UserEntity user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(string id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(f => f.Id == id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                await _dbContext.SaveChangesAsync();
            }
        }

        
    }
}
