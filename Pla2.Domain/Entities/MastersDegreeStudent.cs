namespace Pla2.Domain.Entities;

public class MastersDegreeStudent : Student
{
    public string DiplomaThesisTitle { get; set; }
    
    public Guid ProfessorId { get; set; }
    public virtual Professor Professor { get; set; }
}