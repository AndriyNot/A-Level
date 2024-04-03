using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using HomeWork4._6.Services.Abstractions;

namespace HomeWork4._6.Services
{
    public class DbContextWrapper<T> : IDbContextWrapper<T>
    where T : DbContext
    {
        private readonly T _dbContext;

        public DbContextWrapper(
            IDbContextFactory<T> dbContextFactory)
        {
            _dbContext = dbContextFactory.CreateDbContext();
        }

        public T DbContext => _dbContext;

        public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken)
        {
            return _dbContext.Database.BeginTransactionAsync(cancellationToken);
        }
    }
}
