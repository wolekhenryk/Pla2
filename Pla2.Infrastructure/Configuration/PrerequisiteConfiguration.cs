using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pla2.Domain.Entities;

namespace Pla2.Infrastructure.Configuration;

public class PrerequisiteConfiguration : IEntityTypeConfiguration<Prerequisite>
{
    public void Configure(EntityTypeBuilder<Prerequisite> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.CourseId)
            .HasColumnName("course_id")
            .IsRequired();

        builder.Property(p => p.PrerequisiteCourseId)
            .HasColumnName("prerequisite_course_id")
            .IsRequired();
        
        builder.HasOne(p => p.Course)
            .WithMany(c => c.Prerequisites)
            .HasForeignKey(p => p.CourseId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(p => p.PrerequisiteCourse)
            .WithMany(c => c.PrerequisiteFor)
            .HasForeignKey(p => p.PrerequisiteCourseId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasIndex(p => new { p.CourseId, p.PrerequisiteCourseId })
            .IsUnique();
        
        builder.ToTable(t => t.HasCheckConstraint(
            "ck_prerequisite_no_self_reference",
            "course_id <> prerequisite_course_id"));
    }
}
