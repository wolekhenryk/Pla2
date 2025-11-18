using Microsoft.EntityFrameworkCore;
using Pla2.Domain.Entities;

namespace Pla2.Infrastructure.Data;

public class UniversityDbContext(DbContextOptions<UniversityDbContext> options) : DbContext(options)
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<IndexCounter> IndexCounters { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<Prerequisite> Prerequisites { get; set; }
    public DbSet<Professor> Professors { get; set; }
    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UniversityDbContext).Assembly);
    }
}