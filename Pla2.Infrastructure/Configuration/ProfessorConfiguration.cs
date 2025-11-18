using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pla2.Domain.Entities;

namespace Pla2.Infrastructure.Configuration;

public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
{
    public void Configure(EntityTypeBuilder<Professor> builder)
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
        
        builder.Property(s => s.ScientificTitle)
            .IsRequired();

        builder.HasIndex(s => s.UniversityIndex)
            .IsUnique();

        builder.OwnsOne(s => s.Address);
    }
}