using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.Dtos;

namespace HospitalManagementSystem.Services.Abstract
{
    public interface IDoctorService
    {
        Task<ICollection<Doctor>> GetAllDoctors();
        Task<Doctor> GetDoctor(int id);
        Task AddDoctor(DoctorAddDto doctorAddDto);
        Task UpdateDoctor(DoctorUpdateDto doctorUpdateDto, int id);
        Task RemoveDoctor(int id);
    }
}
