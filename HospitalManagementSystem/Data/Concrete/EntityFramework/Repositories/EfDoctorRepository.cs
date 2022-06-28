using HospitalManagementSystem.Data.Abstract;
using HospitalManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Data.Concrete.EntityFramework.Repositories
{
    public class EfDoctorRepository : EfEntityRepositoryBase<Doctor>, IDoctorRepository
    {
        public EfDoctorRepository(DbContext context) : base(context)
        {
        }
    }
}
