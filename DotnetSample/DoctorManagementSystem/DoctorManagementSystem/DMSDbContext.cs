using System.Reflection;
using Microsoft.EntityFrameworkCore;
using DoctorManagementSystem.Models;

namespace DoctorManagementSystem
{
    public class DMSDbContext : DbContext
    {
        public DMSDbContext(DbContextOptions<DMSDbContext> options) : base(options)
        {
        }

        public required DbSet<DMS> DMS { get; set; }
        public required DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<DoctorManagementSystem.Models.Patient> Patient { get; set; } = default!;
        //public DbSet<DMS> DMSS { get; set; } = default!;

    }
}
    
