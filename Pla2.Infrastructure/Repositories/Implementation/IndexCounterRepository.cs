using Microsoft.EntityFrameworkCore;
using Pla2.Domain.Entities;
using Pla2.Infrastructure.Data;
using Pla2.Infrastructure.Repositories.Interfaces;

namespace Pla2.Infrastructure.Repositories.Implementation;

public class IndexCounterRepository(UniversityDbContext dbContext) : IIndexCounterRepository
{
    public Task<IndexCounter?> GetByPrefixAsync(char prefix, CancellationToken ct = default) =>
        dbContext.IndexCounters.FirstOrDefaultAsync(ic => ic.Prefix == prefix, ct);

    public Task IncrementAsync(IndexCounter indexCounter, CancellationToken ct = default)
    {
        indexCounter.CurrentValue++;
        return Task.CompletedTask;
    }

    public Task DecrementAsync(IndexCounter indexCounter, CancellationToken ct = default)
    {
        indexCounter.CurrentValue--;
        return Task.CompletedTask;
    }
}