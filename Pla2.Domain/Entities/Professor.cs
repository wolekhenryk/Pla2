using Pla2.Domain.Entities.Base;

namespace Pla2.Domain.Entities;

public class Professor : BasicDbEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UniversityIndex { get; set; }
    public ScientificTitle ScientificTitle { get; set; }
    public Address Address { get; set; }
    public Office Office { get; set; }
    public virtual ICollection<MastersDegreeStudent> MastersDegreeStudents { get; set; } = [];
}