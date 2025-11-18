using Pla2.Domain.Entities;
using Pla2.Infrastructure.Data;
using Pla2.Infrastructure.Repositories.Interfaces;

namespace Pla2.Infrastructure.Repositories.Implementation;

public class StudentRepository(UniversityDbContext dbContext) : Repository<Student>(dbContext), IStudentRepository;