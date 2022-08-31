using Microsoft.Extensions.Hosting; 
using Microsoft.Extensions.DependencyInjection; 

namespace COSGenerator; 

public static class Program
{
    public static async Task Main()
    {
        // Write startup text
        Console.ForegroundColor = ConsoleColor.Yellow; 
        Console.WriteLine("2022 - Molecule Software Solutions Inc.");
        Console.WriteLine("Joshua H. Santiago and Matthew J. Bracey - Developers");
        Console.WriteLine("Certificate of Service Generator Application");
        Console.ResetColor(); 

        var builder = Host.CreateDefaultBuilder();

        // Create the service host
        builder.ConfigureServices(services =>
        {
            services.AddTransient<Application>();
            services.AddTransient<MainMenu>();
        });

        var host = await builder.StartAsync();
        host.Services.GetService<Application>();
    }
}