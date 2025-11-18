using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pla2.Application.Cqrs.StudentFeatures.Commands;
using Pla2.Infrastructure.Data;

namespace Pla2.Console;

public class ConsoleApp(
    IServiceProvider serviceProvider,
    IHostApplicationLifetime lifetime) : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        try
        {
            using var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<UniversityDbContext>();
            
            System.Console.WriteLine("Console app started!");
            System.Console.WriteLine("Database connection configured and ready.");
            
            var canConnect = await dbContext.Database.CanConnectAsync(cancellationToken);
            System.Console.WriteLine($"Database connection test: {(canConnect ? "SUCCESS" : "FAILED")}");
            
            var command = new CreateStudentCommand("John", "Doe", 4);
            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();
            
            var result = await mediator.Send(command, cancellationToken);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            lifetime.StopApplication();
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        System.Console.WriteLine("Console app stopped.");
        return Task.CompletedTask;
    }
}
