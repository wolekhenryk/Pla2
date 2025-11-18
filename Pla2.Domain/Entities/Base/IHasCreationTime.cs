namespace Pla2.Domain.Entities.Base;

public interface IHasCreationTime
{
    DateTime CreatedAtUtc { get; set; }
}