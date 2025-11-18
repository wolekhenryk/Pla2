using Pla2.Domain.Entities.Base;

namespace Pla2.Domain.Entities;

public class Course : BasicDbEntity
{
    public string Name { get; set; }
    public string Code { get; set; }
    public int EctsPoints { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = [];

    // Kursy, które są wymagane dla tego kursu
    public virtual ICollection<Prerequisite> Prerequisites { get; set; } = [];

    // Kursy, dla których ten kurs jest wymaganiem
    public virtual ICollection<Prerequisite> PrerequisiteFor { get; set; } = [];
}