using Microsoft.EntityFrameworkCore.Storage;

namespace Pla2.Infrastructure.Repositories.Interfaces;

public interface IUnitOfWork
{
    Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken ct = default);
    Task<int> SaveChangesAsync(CancellationToken ct = default);
}