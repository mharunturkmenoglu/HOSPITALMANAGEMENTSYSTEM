using HospitalManagementSystem.Data.Abstract;
using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.Dtos;
using HospitalManagementSystem.Services.Abstract;

namespace HospitalManagementSystem.Services.Concrete
{
    public class DoctorManager : IDoctorService
    {
        private readonly IUnitOfWork _unitofWork;

        public DoctorManager(IUnitOfWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public async Task AddDoctor(DoctorAddDto doctorAddDto)
        {
            await _unitofWork.Doctors.AddAsync(new Doctor 
            {
                Address = doctorAddDto.Address,
                Name = doctorAddDto.Name,
                No = doctorAddDto.No,
                Surname=doctorAddDto.Surname}
            );
            await _unitofWork.SaveAsync();
        }

        public async Task<Doctor> GetDoctor(int id)
        {
            var doctor = await _unitofWork.Doctors.GetAsync(x => x.Id == id);
            return doctor;
        }

        public async Task RemoveDoctor(Doctor doctor)
        {
            await _unitofWork.Doctors.DeleteAsync(doctor);
            await _unitofWork.SaveAsync();
        }

        public async Task UpdateDoctor(DoctorUpdateDto doctorUpdateDto, int id)
        {
            id = 6;
            var doctor = new Doctor
            {
                Id = id,
                Address = doctorUpdateDto.Address,
                Name = doctorUpdateDto.Name,
                No = doctorUpdateDto.No,
                Surname = doctorUpdateDto.Surname
            };
            await _unitofWork.Doctors.UpdateAsync(doctor);
            await _unitofWork.SaveAsync();
        }
    }
}
