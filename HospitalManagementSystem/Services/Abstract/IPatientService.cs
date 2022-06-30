using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.Dtos;

namespace HospitalManagementSystem.Services.Abstract
{
    public interface IPatientService
    {
        Task<ICollection<Patient>> GetAllPatients();
        Task<Patient> GetPatient(int id);
        Task AddPatient(PatientAddDto patientAddDto);
        Task UpdatePatient(PatientUpdateDto patientUpdateDto, int id);
        Task RemovePatient(int id);
    }
}
