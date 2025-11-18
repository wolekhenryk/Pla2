using Pla2.Domain.Entities.Base;

namespace Pla2.Domain.Entities;

public class Enrollment : BasicDbEntity
{
    public decimal Grade { get; set; }
    public int Semester { get; set; }

    public Guid StudentId { get; set; }
    public virtual Student Student { get; set; }

    public Guid CourseId { get; set; }
    public virtual Course Course { get; set; }
}