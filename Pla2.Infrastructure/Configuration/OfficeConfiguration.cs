using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pla2.Domain.Entities;

namespace Pla2.Infrastructure.Configuration;

public class OfficeConfiguration : IEntityTypeConfiguration<Office>
{
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        builder.HasKey(o => o.Id);
        
        builder.Property(o => o.Id)
            .ValueGeneratedNever();
        
        builder.HasOne<Professor>()
            .WithOne(p => p.Office)
            .HasForeignKey<Office>(o => o.Id)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(o => o.Name)
            .IsUnique();

    }
}