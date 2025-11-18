using AutoMapper;
using Pla2.Application.Cqrs.StudentFeatures.Commands;
using Pla2.Domain.Entities;

namespace Pla2.Application.Mappings;

public class StudentMappingProfile : Profile
{
    public StudentMappingProfile()
    {
        CreateMap<CreateStudentCommand, Student>()
            .ForMember(dest => dest.UniversityIndex, opt => opt.Ignore())
            .ForMember(dest => dest.Address, opt => opt.Ignore())
            .ForMember(dest => dest.Enrollments, opt => opt.Ignore())
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedAtUtc, opt => opt.Ignore());
    }
}
