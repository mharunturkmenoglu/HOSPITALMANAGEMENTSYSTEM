using HospitalManagementSystem.Entities.Abstract;
using HospitalManagementSystem.Entities.Concrete;

namespace HospitalManagementSystem.Data.Abstract
{
    public interface IDoctorRepository : IEntityRepository<Doctor>
    {
    }
}
