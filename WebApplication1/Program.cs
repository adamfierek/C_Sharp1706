using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TestApp.Services;
using WebApplication1.Data;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            builder.Services.AddControllers();
            builder.Services.AddSingleton<MeasurementService>();

            builder.Services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlite(configuration["ConnectionString"]);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}