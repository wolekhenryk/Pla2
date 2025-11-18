using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pla2.Domain.Entities.Base;

namespace Pla2.Infrastructure.Repositories.Interfaces;

public interface IRepository<T> where T : BasicDbEntity
{
    Task<T?> GetByIdAsync(Guid id, CancellationToken ct = default);
    Task<List<T>> GetAllAsync(CancellationToken ct = default);
    ValueTask<EntityEntry<T>> AddAsync(T entity,  CancellationToken ct = default);
    void Update(T entity);
    void Delete(T entity);
}