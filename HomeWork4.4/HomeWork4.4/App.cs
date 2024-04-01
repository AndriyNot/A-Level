using HomeWork4._4.Data;
using Microsoft.EntityFrameworkCore;
namespace HomeWork4._4
{
    public class App
    {
        private readonly ApplicationDbContext _dbContext;

        public App(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Start()
        {
            var data = await _dbContext.Pets.ToListAsync();
        }
    }
}
