using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;

namespace HomeWork4._5.Service.Abstractions
{
    public interface IDbContextWrapper<T>
    where T : DbContext
    {
        T DbContext { get; }
        Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken);
    }
}
