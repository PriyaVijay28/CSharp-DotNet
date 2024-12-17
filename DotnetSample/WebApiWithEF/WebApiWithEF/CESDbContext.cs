using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WebApiWithEF.Models;

namespace WebApiWithEF
{
    public class CESDbContext : DbContext
    {
        public CESDbContext(DbContextOptions<CESDbContext> options):base(options) { }
        //public DbSet<CESDbContext>? CES { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<WebApiWithEF.Models.CES> CES { get; set; } = default!;

    }
}
    

