using HospitalManagementSystem.Data.Abstract;
using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.Dtos;
using HospitalManagementSystem.Services.Abstract;

namespace HospitalManagementSystem.Services.Concrete
{
    public class PatientManager : IPatientService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PatientManager(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task AddPatient(PatientAddDto patientAddDto)
        {
            await _unitOfWork.Patients.AddAsync(new Patient
            {
                Address = patientAddDto.Address,
                InsuranceNo = patientAddDto.InsuranceNo,
                Name = patientAddDto.Name,
                No = patientAddDto.No,
                Surname = patientAddDto.Surname
            });
            await _unitOfWork.SaveAsync();
        }

        public async Task<ICollection<Patient>> GetAllPatients()
        {
            var patientList = await _unitOfWork.Patients.GetAllAsync();
            return patientList;
        }

        public async Task<Patient> GetPatient(int id)
        {
            var patient = await _unitOfWork.Patients.GetAsync(x => x.Id == id);
            return patient;
        }

        public async Task RemovePatient(int id)
        {
            var patient = await _unitOfWork.Patients.GetAsync(x => x.Id == id);
            await _unitOfWork.Patients.DeleteAsync(patient);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdatePatient(PatientUpdateDto patientUpdateDto, int id)
        {
            var patient =new Patient
            {
                Id= id,
                Address = patientUpdateDto.Address,
                InsuranceNo = patientUpdateDto.InsuranceNo,
                Surname = patientUpdateDto.Surname,
                Name = patientUpdateDto.Name,
                No = patientUpdateDto.No
            };
            await _unitOfWork.Patients.UpdateAsync(patient);
            await _unitOfWork.SaveAsync();
        }
    }
}
