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
    }
}
