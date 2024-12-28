using System.Reflection;
using DoctorManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorManagement
{
    public class DMDbContext : DbContext
    {
        public DMDbContext(DbContextOptions options) : base(options) { }

        DbSet<DM> Doctor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<DoctorManagement.Models.DM> DM { get; set; } = default!;
    }
}
