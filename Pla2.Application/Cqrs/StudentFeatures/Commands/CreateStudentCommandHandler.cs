using AutoMapper;
using FluentResults;
using MediatR;
using Pla2.Domain.Entities;
using Pla2.Infrastructure.Repositories.Interfaces;

namespace Pla2.Application.Cqrs.StudentFeatures.Commands;

public class CreateStudentCommandHandler(
    IMapper mapper,
    IStudentRepository studentRepository,
    IIndexCounterRepository indexCounterRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<CreateStudentCommand, Result>
{
    public async Task<Result> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
    {
        var mappedStudent = mapper.Map<Student>(request);
        return Result.Ok();
    }
}