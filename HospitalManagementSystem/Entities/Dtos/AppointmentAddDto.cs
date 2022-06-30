using HospitalManagementSystem.Entities.Concrete;

namespace HospitalManagementSystem.Entities.Dtos
{
    public class AppointmentAddDto
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
