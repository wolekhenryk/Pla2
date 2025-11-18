using FluentResults;
using MediatR;

namespace Pla2.Application.Cqrs.StudentFeatures.Commands;

public record CreateStudentCommand(string FirstName, string LastName, int YearOfStudy) : IRequest<Result>;