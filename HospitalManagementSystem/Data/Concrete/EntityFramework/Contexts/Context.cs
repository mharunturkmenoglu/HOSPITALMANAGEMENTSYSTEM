using HospitalManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Data.Concrete.EntityFramework.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Patient>? Patients { get; set; }
        public DbSet<Doctor>? Doctors { get; set; }
        public DbSet<Appointment>? Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Patient>().HasIndex(x => x.InsuranceNo).IsUnique(true);
            builder.Entity<Patient>().HasIndex(x => x.No).IsUnique(true);
            builder.Entity<Doctor>().HasIndex(x => x.No).IsUnique(true);
        }
    }
}
