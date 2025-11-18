using Microsoft.EntityFrameworkCore.Storage;
using Pla2.Infrastructure.Data;
using Pla2.Infrastructure.Repositories.Interfaces;

namespace Pla2.Infrastructure.Repositories.Implementation;

public class UnitOfWork(UniversityDbContext dbContext) : IUnitOfWork
{
    public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken ct = default) =>
        dbContext.Database.BeginTransactionAsync(ct);

    public Task<int> SaveChangesAsync(CancellationToken ct = default) =>
        dbContext.SaveChangesAsync(ct);
}