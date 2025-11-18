using Pla2.Domain.Entities.Base;

namespace Pla2.Domain.Entities;

public class Office : BasicDbEntity
{
    public override Guid Id { get; set; }
    public string Name { get; set; }
    
    public Professor Professor { get; set; }
}