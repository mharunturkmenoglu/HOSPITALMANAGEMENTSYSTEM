using HospitalManagementSystem.Data.Abstract;
using HospitalManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Data.Concrete.EntityFramework.Repositories
{
    public class EfAppointmentRepository : EfEntityRepositoryBase<Appointment>, IAppointmentRepository
    {
        public EfAppointmentRepository(DbContext context) : base(context)
        {
        }
    }
}
