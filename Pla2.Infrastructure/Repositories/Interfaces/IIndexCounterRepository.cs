using Pla2.Domain.Entities;

namespace Pla2.Infrastructure.Repositories.Interfaces;

public interface IIndexCounterRepository
{
    Task<IndexCounter?> GetByPrefixAsync(char prefix, CancellationToken ct = default);
    Task IncrementAsync(IndexCounter indexCounter, CancellationToken ct = default);
    Task DecrementAsync(IndexCounter indexCounter, CancellationToken ct = default);
}