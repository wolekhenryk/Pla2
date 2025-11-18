using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pla2.Domain.Entities;

namespace Pla2.Infrastructure.Configuration;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.Name)
            .HasMaxLength(200)
            .IsRequired();
        
        builder.HasIndex(c => c.Name)
            .IsUnique();
        
        builder.Property(c => c.Code)
            .HasMaxLength(50)
            .IsRequired();
        
        builder.HasIndex(c => c.Code)
            .IsUnique();
        
        builder.Property(c => c.EctsPoints)
            .IsRequired();
    }
}