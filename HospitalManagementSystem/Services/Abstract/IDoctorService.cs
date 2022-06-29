using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.Dtos;

namespace HospitalManagementSystem.Services.Abstract
{
    public interface IDoctorService
    {
        Task<Doctor> GetDoctor(int id);
        Task AddDoctor(DoctorAddDto doctorAddDto);
        Task UpdateDoctor(DoctorUpdateDto doctorUpdateDto, int id);
        Task RemoveDoctor(Doctor doctor);
    }
}
