using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            builder.Host.UseSerilog((hostContext, services, configuration) => 
            {
                configuration
                .MinimumLevel.Information()
                .WriteTo.File("C:\\log\\test\\AppLogss.log")
                .WriteTo.Console();
            });

            var app = builder.Build();

            app.UseRouting();
            app.MapControllers();
            app.Run();
        }
    }
}