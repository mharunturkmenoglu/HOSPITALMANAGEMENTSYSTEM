using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.Dtos;

namespace HospitalManagementSystem.Services.Abstract
{
    public interface IAppointmentService
    {
        Task<ICollection<Appointment>> GetAllAppointments();
        Task<Appointment> GetAppointment(int id);
        Task AddAppointment(AppointmentAddDto appoinmentAddDto);
        Task UpdateAppointment(AppointmentUpdateDto appoinmentUpdateDto, int id);
        Task RemoveAppointment(int id);
    }
}
