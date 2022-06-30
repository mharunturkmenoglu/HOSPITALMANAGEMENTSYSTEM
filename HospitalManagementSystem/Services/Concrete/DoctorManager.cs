using HospitalManagementSystem.Data.Abstract;
using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.Dtos;
using HospitalManagementSystem.Services.Abstract;

namespace HospitalManagementSystem.Services.Concrete
{
    public class DoctorManager : IDoctorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DoctorManager(IUnitOfWork unitofWork)
        {
            _unitOfWork = unitofWork;
        }

        public async Task AddDoctor(DoctorAddDto doctorAddDto)
        {
            await _unitOfWork.Doctors.AddAsync(new Doctor
            {
                Address = doctorAddDto.Address,
                Name = doctorAddDto.Name,
                No = doctorAddDto.No,
                Surname = doctorAddDto.Surname
            });
            await _unitOfWork.SaveAsync();
        }

        public async Task<Doctor> GetDoctor(int id)
        {
            var doctor = await _unitOfWork.Doctors.GetAsync(x => x.Id == id);
            return doctor;
        }

        public async Task<ICollection<Doctor>> GetAllDoctors()
        {
            var doctor = await _unitOfWork.Doctors.GetAllAsync();
            return doctor;
        }

        public async Task RemoveDoctor(int id)
        {
            var doctor = await _unitOfWork.Doctors.GetAsync(x => x.Id == id);
            await _unitOfWork.Doctors.DeleteAsync(doctor);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateDoctor(DoctorUpdateDto doctorUpdateDto, int id)
        {
            var doctor = new Doctor
            {
                Id = id,
                Address = doctorUpdateDto.Address,
                Name = doctorUpdateDto.Name,
                No = doctorUpdateDto.No,
                Surname = doctorUpdateDto.Surname
            };
            await _unitOfWork.Doctors.UpdateAsync(doctor);
            await _unitOfWork.SaveAsync();
        }
    }
}
