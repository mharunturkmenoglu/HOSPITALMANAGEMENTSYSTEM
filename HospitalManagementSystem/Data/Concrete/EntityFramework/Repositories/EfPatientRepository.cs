using HospitalManagementSystem.Data.Abstract;
using HospitalManagementSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Data.Concrete.EntityFramework.Repositories
{
    public class EfPatientRepository : EfEntityRepositoryBase<Patient>, IPatientRepository
    {
        public EfPatientRepository(DbContext context) : base(context)
        {
        }
    }
}
