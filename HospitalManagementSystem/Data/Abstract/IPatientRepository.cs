using HospitalManagementSystem.Entities.Abstract;
using HospitalManagementSystem.Entities.Concrete;

namespace HospitalManagementSystem.Data.Abstract
{
    public interface IPatientRepository : IEntityRepository<Patient>
    {
    }
}
