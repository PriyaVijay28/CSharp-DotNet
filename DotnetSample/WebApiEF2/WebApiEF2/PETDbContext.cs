using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WebApiEF2.Models;

namespace WebApiEF2
{
    public class PETDbContext : DbContext
    {
        public PETDbContext(DbContextOptions options):base(options) { }
       
       // DbSet<PET> PETs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<WebApiEF2.Models.PET> PET { get; set; } = default!;
    }
}
