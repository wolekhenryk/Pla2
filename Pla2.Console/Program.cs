using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pla2.Application;
using Pla2.Domain.Entities;
using Pla2.Infrastructure.Data;
using Pla2.Infrastructure.Repositories.Implementation;
using Pla2.Infrastructure.Repositories.Interfaces;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddApplication();
        
        services.AddDbContext<UniversityDbContext>(options =>
            options.UseNpgsql(
                context.Configuration.GetConnectionString("DefaultConnection"),
                npgsqlOptions => npgsqlOptions.MapEnum<ScientificTitle>())
            .UseSnakeCaseNamingConvention());
        services.AddHostedService<Pla2.Console.ConsoleApp>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<IFacultyRepository, FacultyRepository>();
        services.AddScoped<IProfessorRepository, ProfessorRepository>();
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<IIndexCounterRepository, IndexCounterRepository>();
    })
    .Build();

var dbContext = host.Services.GetRequiredService<UniversityDbContext>();
await dbContext.Database.MigrateAsync();

await host.RunAsync(); 