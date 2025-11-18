namespace Pla2.Domain.Entities.Base;

public abstract class BasicDbEntity : IHasIdentity, IHasCreationTime
{
    public virtual Guid Id { get; set; } = Guid.CreateVersion7();
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
}