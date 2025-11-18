using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pla2.Domain.Entities;

namespace Pla2.Infrastructure.Configuration;

public class IndexCounterConfiguration : IEntityTypeConfiguration<IndexCounter>
{
    public void Configure(EntityTypeBuilder<IndexCounter> builder)
    {
        builder.HasKey(ic => ic.Prefix);

        builder.Property(ic => ic.Prefix)
            .IsRequired()
            .HasColumnType("char(1)")
            .ValueGeneratedNever();

        builder.Property(ic => ic.CurrentValue)
            .HasDefaultValue(0);
    }
}
