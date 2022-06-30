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
            builder.Entity<Appointment>()
                .HasOne(x => x.Doctor)
                .WithMany(x => x.Appointments)
                .HasForeignKey(x => x.DoctorId)
                .HasPrincipalKey(x => x.Id);

            builder.Entity<Appointment>()
                .HasOne(x => x.Patient).WithMany(x => x.Appointments).HasForeignKey(x => x.PatientId).HasPrincipalKey(x => x.Id);
        }
    }
}
