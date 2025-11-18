using Pla2.Domain.Entities.Base;

namespace Pla2.Domain.Entities;

public class Student : BasicDbEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UniversityIndex { get; set; }
    public int YearOfStudy { get; set; }
    
    public Address Address { get; set; }
    
    public virtual ICollection<Enrollment> Enrollments { get; set; } = [];
}