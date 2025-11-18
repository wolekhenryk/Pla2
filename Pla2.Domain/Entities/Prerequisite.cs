using Pla2.Domain.Entities.Base;

namespace Pla2.Domain.Entities;

public class Prerequisite : BasicDbEntity
{
    public Guid CourseId { get; set; }
    public virtual Course Course { get; set; }

    public Guid PrerequisiteCourseId { get; set; }
    public virtual Course PrerequisiteCourse { get; set; }
}