using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pla2.Domain.Entities;

namespace Pla2.Infrastructure.Configuration;

public class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
{
    public void Configure(EntityTypeBuilder<Faculty> builder)
    {
        builder.HasKey(f => f.Id);
        
        builder.Property(f => f.Name)
            .HasMaxLength(200)
            .IsRequired();
        
        builder.HasIndex(f => f.Name)
            .IsUnique();
    }
}