using Microsoft.EntityFrameworkCore;
using TestApp.Models;

namespace WebApplication1.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Measurement> Measurements { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        //(tworzenie migracji) dotnet ef migrations add Init --output-dir "Data/Migrations"
        //(aktualizacja bazy danych) dotnet ef database update
    }
}
