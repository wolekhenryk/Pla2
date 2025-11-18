using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pla2.Domain.Entities;

namespace Pla2.Infrastructure.Configuration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(s => s.Id);
        
        builder.Property(s => s.FirstName)
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(s => s.LastName)
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(s => s.UniversityIndex)
            .HasMaxLength(10)
            .IsRequired();
        
        builder.Property(s => s.YearOfStudy)
            .IsRequired();

        builder.HasIndex(s => s.UniversityIndex)
            .IsUnique();

        builder.OwnsOne(s => s.Address);
    }
}