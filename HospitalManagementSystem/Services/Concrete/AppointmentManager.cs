using HospitalManagementSystem.Data.Abstract;
using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.Dtos;
using HospitalManagementSystem.Services.Abstract;

namespace HospitalManagementSystem.Services.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AppointmentManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAppointment(AppointmentAddDto appoinmentAddDto)
        {
            await _unitOfWork.Appointments.AddAsync(new Appointment
            {
                DoctorId = appoinmentAddDto.DoctorId,
                PatientId = appoinmentAddDto.PatientId,
                AppointmentDate = appoinmentAddDto.AppointmentDate
            });
            await _unitOfWork.SaveAsync();
        }

        public async Task<ICollection<Appointment>> GetAllAppointments()
        {
            var appointmentList = await _unitOfWork.Appointments.GetAllAsync();
            return appointmentList;
        }

        public async Task<Appointment> GetAppointment(int id)
        {
            var appointment = await _unitOfWork.Appointments.GetAsync(x => x.Id == id);
            return appointment;
        }

        public async Task RemoveAppointment(int id)
        {
            var appointment = await _unitOfWork.Appointments.GetAsync(x => x.Id == id);
            await _unitOfWork.Appointments.DeleteAsync(appointment);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateAppointment(AppointmentUpdateDto appoinmentUpdateDto, int id)
        {
            var appointment = new Appointment
            {
                Id = id,
                DoctorId = appoinmentUpdateDto.DoctorId,
                PatientId = appoinmentUpdateDto.PatientId,
                AppointmentDate = appoinmentUpdateDto.AppointmentDate
            };
            await _unitOfWork.Appointments.UpdateAsync(appointment);
            await _unitOfWork.SaveAsync();
        }
    }
}
