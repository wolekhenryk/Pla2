using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pla2.Domain.Entities.Base;
using Pla2.Infrastructure.Data;
using Pla2.Infrastructure.Repositories.Interfaces;

namespace Pla2.Infrastructure.Repositories.Implementation;

public class Repository<T>(UniversityDbContext dbContext) : IRepository<T> where T : BasicDbEntity
{
    public Task<T?> GetByIdAsync(Guid id, CancellationToken ct = default) =>
        dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id, ct);

    public Task<List<T>> GetAllAsync(CancellationToken ct = default) =>
        dbContext.Set<T>().ToListAsync(ct);

    public ValueTask<EntityEntry<T>> AddAsync(T entity, CancellationToken ct = default) =>
        dbContext.Set<T>().AddAsync(entity, ct);

    public void Update(T entity) => dbContext.Set<T>().Update(entity);

    public void Delete(T entity) => dbContext.Set<T>().Remove(entity);
}